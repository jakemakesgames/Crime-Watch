using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("location");
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = target.transform.position;
    }
}
