using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    public GameObject target;
    public GameObject returnTarget;
    public GameObject successfulPanel;
    public PlayerStatsManager playerStatsManager;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("location");
        returnTarget = null;
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = target.transform.position;

        playerStatsManager = FindObjectOfType<PlayerStatsManager>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "location")
        {
            playerStatsManager.arrestCount += 1;
            playerStatsManager.dailyBudget += 250;
            playerStatsManager.xp += 50;
            Debug.Log("Arrest made");

            returnTarget = GameObject.FindGameObjectWithTag("PoliceStation");
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = returnTarget.transform.position;

            Destroy(other.gameObject);
            
            if (other.tag == "PoliceStation")
            {
                Destroy(this.gameObject);
            }
        }

        
    }
}
