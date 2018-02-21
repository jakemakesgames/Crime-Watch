using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	public GameObject policeBlip;
	public Transform policeStation;

	// Use this for initialization
	void Start () 
	{
		SpawnPolice ();
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
