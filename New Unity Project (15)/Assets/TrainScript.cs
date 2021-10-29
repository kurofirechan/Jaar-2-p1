using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class TrainScript : MonoBehaviour
{
    public GameObject endPos;
    private void Start()
    {
        endPos = GameObject.FindGameObjectWithTag("End");
        GetComponent<NavMeshAgent>().destination = endPos.transform.position;
    }
}
