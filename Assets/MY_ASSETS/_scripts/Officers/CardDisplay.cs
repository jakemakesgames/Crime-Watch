using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour 
{
	public OfficerCard officerCard;
	public PlayerStatsManager playerStatsManager;
    public PlayerMovement playerMovement;
    public Button btn;

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
		playerStatsManager = FindObjectOfType<PlayerStatsManager> ();

        playerMovement = FindObjectOfType<PlayerMovement>();
        // all of the public variables are set when the game is start //
        nameText.text = officerCard.name;
		descriptionText.text = officerCard.description;

		displayImage.sprite = officerCard.image;

		costText.text = officerCard.moneyCost.ToString ();
		levelText.text = officerCard.level.ToString ();
		xpText.text = officerCard.xp.ToString ();
	}

	public void GetStats()
	{
		Debug.Log (officerCard.name + ": " + officerCard.description + ", " + officerCard.moneyCost + ", " + officerCard.level + ", " + officerCard.xp);
	}

	public void SelectedOfficers()
	{
		// Add selected officers to a list //
	}

    public void ConfirmDispatch()
    {
        // remove budget from all officer's in the list //
        playerStatsManager.dailyBudget -= officerCard.moneyCost;

        if (playerStatsManager.dailyBudget >= 0)
        {
            playerStatsManager.xp += 10;
            playerMovement.SpawnPolice();
            Debug.Log(officerCard.name + " has been dispatched!");
        }
        
        // put the below comments in another function //
        // send gameObjects out here //
        // instantiate officer & send them to the scenario//

        // UPDDATE THE PLAYER'S CURRENT DAILY BUDGET //
        if (playerStatsManager.dailyBudget <= 0)
        {
            // Display a Message //
            Debug.Log("You don't have enough money!");
            playerStatsManager.dailyBudget = 0;

            
        }

        
    }



}
