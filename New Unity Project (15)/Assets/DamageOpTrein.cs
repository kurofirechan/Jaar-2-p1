using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOpTrein : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<TrainScript>())
        {
            FindObjectOfType<GameManager>().DoDamage();
            Destroy(other.transform.gameObject);
        }
    }
}
