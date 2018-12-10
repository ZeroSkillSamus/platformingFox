using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkOnNPCActivity : MonoBehaviour {

	public PlayerMovement player;
	public GameObject firstNPC;
	public GameObject secondNPC;
	public GameObject thirdNPC;
	public GameObject fourthNPC;
	// Update is called once per frame
	void Update () 
	{
		if (secondNPC.activeSelf == false && firstNPC.activeSelf==false) 
		{
			player.allowJump = true;
		}
		if (thirdNPC.activeSelf == false && fourthNPC.activeSelf==true) 
		{
//			Debug.Log ("ss");
			player.allowCrouch = true;
		}
	}
}
