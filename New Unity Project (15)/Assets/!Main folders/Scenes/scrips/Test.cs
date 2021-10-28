using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    RaycastHit hit;
    public float damage;

    void Update()
    {
        DoCast();
    }
    void DoCast()

    {
        if (Input.GetMouseButtonDown(0))

            if (Physics.Raycast(transform.position, transform.forward, out hit, 500))
            {
                if (hit.transform.tag == "Enemy")
                {
                    hit.transform.GetComponent<Heaalth>().DoDamage(damage);
                }
            }
    }
}