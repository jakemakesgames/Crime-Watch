using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatsManager : MonoBehaviour
{
    [Header("Direct Stats")]
    public int arrestCount;
    public float dailyBudget;
    public float level;
    public float xp;

    [Header("Stats Text Elements")]
    public Text arrestCountText;
    public Text dailyBudgetText;
    public Text levelText;
    public Text xpText;

    [Header("Day/ Time")]
    public string day;
    public Text dayText;


    // Use this for initialization
    void Start ()
    {
        // Set the UI elements //
        arrestCountText.text = "Arrests: " + arrestCount.ToString();
        dailyBudgetText.text = "$" + dailyBudget.ToString();
        levelText.text = "LVL: " + level.ToString();
        xpText.text = "XP: " + xp.ToString();

        dayText.text = day.ToString();
    }

	void Update()
	{
		arrestCountText.text = "Arrests: " + arrestCount.ToString();
		dailyBudgetText.text = "$" + dailyBudget.ToString();
		levelText.text = "LVL: " + level.ToString();
		xpText.text = "XP: " + xp.ToString();

		dayText.text = day.ToString();

        if (xp == 100)
        {
            level = 2;
        }
	}

}
