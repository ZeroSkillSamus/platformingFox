using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateScript : MonoBehaviour {

	public Transform target;
	private Animator anim;
	public float speed;
	public PlayerMovement player;
	public GameObject npc;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();	
	}

	// Update is called once per frame
	void Update () 
	{
		if (player.getCutScene() == true) {
			float step = speed * Time.deltaTime;
			anim.SetFloat ("speed", 22f);
			transform.position = Vector3.MoveTowards (transform.position, target.position, step);
			checkDistance ();
			//Debug.Log (step);
		}
	}

	void checkDistance()
	{
		var heading = (npc.transform.position - transform.position);
		var distance = heading.magnitude;

		if (distance < 2.8) {
			//anim.SetBool ("isIdle", true);
			player.setCutScene (false);
			anim.SetFloat ("speed", 0f);
		}
	}

}
