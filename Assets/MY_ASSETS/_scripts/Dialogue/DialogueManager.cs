using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour 
{
	public Text nameText;
	public Text dialogueText;

    public GameObject contButton;
    public GameObject answerButton;
    public GameObject answerText;

    public GameObject audioWaves;
    // PUT IN OTHER SCRIPT, JUST HERE FOR TESTING PURPOSES //
    public Transform location;
    public Transform blips;

    private Queue<string> sentences;

	void Start()
	{
        audioWaves.SetActive(false);
        contButton.SetActive(false);
		sentences = new Queue<string> ();
	}

	public void StartDialogue(Dialogue dialogue)
	{
		Debug.Log ("Starting conversation with " + dialogue.name);

		nameText.text = dialogue.name;
		sentences.Clear ();

		foreach (string sentence in dialogue.sentences) 
		{
			sentences.Enqueue (sentence);
		}
        contButton.SetActive(true);

        answerButton.SetActive(false);
        answerText.SetActive(false);
        audioWaves.SetActive(true);

		DisplayNextSentence ();
	}

	public void DisplayNextSentence()
	{
		if (sentences.Count == 0)
		{
			EndDialogue ();
			return;
		}

		string sentence = sentences.Dequeue ();
		dialogueText.text = sentence;
		Debug.Log (sentence);
	}

	void EndDialogue()
	{
		Debug.Log ("End of conversation");
        InstantiateBlip();
        contButton.SetActive(false);
    }

    public void InstantiateBlip()
    {
        Instantiate(blips, location.position, Quaternion.identity);
    }
}
