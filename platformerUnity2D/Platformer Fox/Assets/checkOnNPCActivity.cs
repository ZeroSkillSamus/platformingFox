using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkOnNPCActivity : MonoBehaviour {

	public PlayerMovement player;
	public GameObject firstNPC;
	public GameObject secondNPC;
	public GameObject thirdNPC;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (secondNPC.active == false && firstNPC.active==false) 
		{
			player.allowJump = true;
		}
	}
}
