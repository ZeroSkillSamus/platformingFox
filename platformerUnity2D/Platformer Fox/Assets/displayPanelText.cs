using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayPanelText : MonoBehaviour {

	public GameObject game;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

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
}
