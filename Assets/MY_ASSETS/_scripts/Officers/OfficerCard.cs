using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Officer", menuName = "Officer")]
public class OfficerCard : ScriptableObject 
{
	// name and description of officer //
	public new string name;
	public string description;

	// image of officer //
	public Sprite image;

	// resources and currency costs //
	public int moneyCost;
	public int level;
	public int xp;

	public void Print()
	{
		Debug.Log (name + ": " + description + ", " + moneyCost + ", " + level + ", " + xp);
	}

}
