using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour 
{
	public OfficerCard officerCard;

	// name and description text elements //
	public Text nameText;
	public Text descriptionText;

	// image element //
	public Image displayImage;

	// resources and currency text element //
	public Text costText;
	public Text levelText;
	public Text xpText;

	// Use this for initialization
	void Start () 
	{
		// all of the public variables are set when the game is start //
		nameText.text = officerCard.name;
		descriptionText.text = officerCard.description;

		displayImage.sprite = officerCard.image;

		costText.text = officerCard.moneyCost.ToString ();
		levelText.text = officerCard.level.ToString ();
		xpText.text = officerCard.xp.ToString ();
	}

}
