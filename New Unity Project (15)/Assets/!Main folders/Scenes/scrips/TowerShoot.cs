using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShoot : MonoBehaviour
{
    public Rigidbody Bullet;
    public Transform bulletSpawnLocation;
    public float damage, attackSpeed, bulletSpeed;
    private float nextAttack, attackCooldown;

    List<GameObject> targets;

    private void Awake()
    {
        targets = new List<GameObject>();
    }
    private void Start()
    {
        CalculateAttackSpeed();
    }
    public void CalculateAttackSpeed()
    {
        attackCooldown = attackSpeed / (attackSpeed * attackSpeed);
    }
    void Update()
    {
        LookAtTarget();
    }
    void LookAtTarget()
    {
        targets.RemoveAll(GameObject => GameObject == null);
        if (targets.Count > 0)
        {
            transform.LookAt(targets[0].transform);
            if (Time.time >= nextAttack)
            {
                nextAttack = attackCooldown + Time.time;
                ShootBullet();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Heaalth>())
        {
            print(other.name);
            targets.Add(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Heaalth>())
        {
            targets.Remove(other.gameObject);
        }
    }
    public void ShootBullet()
    {
        Rigidbody spawnedBulled = Instantiate(Bullet, bulletSpawnLocation.position, transform.rotation);
        spawnedBulled.velocity = spawnedBulled.transform.forward * bulletSpeed;
        spawnedBulled.GetComponent<BulletDamage>().damage = damage;
    }
}
