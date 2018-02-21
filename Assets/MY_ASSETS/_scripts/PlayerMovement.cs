using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour 
{
	public GameObject policeBlip;
	public Transform policeStation;

    public PlayerStatsManager playerStatsManager;
    public locationSpawner lSpawner;
    public CardDisplay cardDisplay;


    // Use this for initialization
    void Start () 
	{
        lSpawner = FindObjectOfType<locationSpawner>();
        playerStatsManager = FindObjectOfType<PlayerStatsManager>();
        cardDisplay = FindObjectOfType<CardDisplay>();
        //officerCard = FindObjectOfType<OfficerCard>();
    }
	
	// Update is called once per frame
	void Update () 
	{
		
	}
    

	public void SpawnPolice()
	{
		Instantiate (policeBlip, policeStation.position, policeStation.rotation);
        
	}

    
}
