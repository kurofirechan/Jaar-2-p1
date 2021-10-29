using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public float damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Heaalth>())
        {
            other.GetComponent<Heaalth>().DoDamage((int)damage);
        }
    }
}
