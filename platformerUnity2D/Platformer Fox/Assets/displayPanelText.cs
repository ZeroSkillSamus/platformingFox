using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class displayPanelText : MonoBehaviour {

	public GameObject game;
	public GameObject panel;


	public Text text;

	//public SpriteRenderer sp;

	void Start () {
		//game = GetComponent<GameObject> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		checkSpriteRenderer ();
	}

	void checkSpriteRenderer()
	{
		if (game.activeSelf == false) 
		{
			
		}
	}
	/*
	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Player") 
		{
			game.SetActive (true);
		}
	}
	void OnTriggerExit2D(Collider2D collider)
	{
		game.SetActive (false);
	}
	*/
}
