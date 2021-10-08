    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AgentScript : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent agent;
    public GameObject target;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = target.transform.position;
    }
}
