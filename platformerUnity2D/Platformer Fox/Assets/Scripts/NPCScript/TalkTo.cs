using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkTo : MonoBehaviour {
	public GameObject player;
	public GameObject npc;
	public GameObject panel;
	private Rigidbody2D rigid;
	// Use this for initialization

	void Start()
	{
		
	}
	// Update is called once per frame
	void Update () 
	{
		var heading = (npc.transform.position - player.transform.position);
		var distance = heading.magnitude;
		if (distance < 3) {
			panel.SetActive (true);
			//rigid.constraints = RigidbodyConstraints2D.FreezeAll;
			//rigid.constraints = RigidbodyConstraints2D
			//rigid.constraints = RigidbodyConstraints2D.FreezePositionY;
		} else {
			panel.SetActive (false);
		}

	}
}
