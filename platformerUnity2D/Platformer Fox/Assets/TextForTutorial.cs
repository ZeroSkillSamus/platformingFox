using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextForTutorial : MonoBehaviour {

	public string[] sentences;
	private Queue<string> textToDisplay;
	public Text dialogueNameText;
	public Text npcNameText;
	public GameObject npc;
	public GameObject panel;
	public GameObject nextNPC;
	// Use this for initialization
	void Start () 
	{
		
		textToDisplay = new Queue<string> ();
		foreach (string sentence in sentences) 
		{
			textToDisplay.Enqueue (sentence);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		displayThatText ();
	}

	void displayThatText()
	{
		if (this.textToDisplay.Count == 2) 
		{
			npcNameText.text = "NPC Name: Old Man Tutorial Guy";
		}
		if (Input.GetKeyDown (KeyCode.F) && this.textToDisplay.Count != 0) 
		{
			string s = textToDisplay.Dequeue ();
			dialogueNameText.text = s;
		} 
		else if (this.textToDisplay.Count == 0) 
		{
			npc.SetActive (false);
			panel.SetActive (false);
			nextNPC.SetActive (true);
		}

	}
		
}
