using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heaalth : MonoBehaviour
{

    public int moneyperTrain;
    public float health;
    public void DoDamage(float f)
    {
        health -= f;
        if (health <= 0)
        {
            FindObjectOfType<MenuScript>().AddMoney(moneyperTrain);
            Destroy(gameObject);
        }
    }
}
