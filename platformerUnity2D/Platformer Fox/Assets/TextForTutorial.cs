using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextForTutorial : MonoBehaviour {

	public string[] sentences;
	private Queue<string> textToDisplay;
	public Text dialogueNameText;
	public Text npcNameText;

	// Use this for initialization
	void Start () 
	{
		textToDisplay = new Queue<string> ();
		foreach (string sentence in sentences) 
		{
			textToDisplay.Enqueue (sentence);
		}
		Debug.Log ("S");
	}
	
	// Update is called once per frame
	void Update () 
	{
		displayThatText ();
	}

	void displayThatText()
	{
		
		if (Input.GetKeyDown (KeyCode.F) && this.textToDisplay.Count!=0) 
		{
			string s = textToDisplay.Dequeue();
			dialogueNameText.text = s;
		}
		if (this.textToDisplay.Count == 0) 
		{
			npcNameText.text = "NPC Name: Old Man Tutorial Guy";
		}
	}
}
