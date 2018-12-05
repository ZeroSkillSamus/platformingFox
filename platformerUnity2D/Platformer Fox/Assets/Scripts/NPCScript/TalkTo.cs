using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkTo : MonoBehaviour {
	public GameObject player;
	public GameObject npc;
	public GameObject panel;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () 
	{
		var heading = (npc.transform.position - player.transform.position);
		var distance = heading.magnitude;
		if (distance < 3) {
			panel.SetActive (true);
		} else {
			panel.SetActive (false);
		}
	}
}
