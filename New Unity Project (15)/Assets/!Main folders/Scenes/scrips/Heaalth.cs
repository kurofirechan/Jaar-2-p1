using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heaalth : MonoBehaviour
{
  
  
    public float health;
    public void DoDamage(float f)
    {
        health -= f;
        if (health <= (0))
        {
            Destroy(gameObject);
        }
    }
}
