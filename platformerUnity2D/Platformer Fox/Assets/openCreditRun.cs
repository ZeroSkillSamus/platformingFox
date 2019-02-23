using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openCreditRun : MonoBehaviour {
	public Transform target;
	public Transform startPos;
	public float x,y,z;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float step = 10 * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target.position, step);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Wall") {
			transform.position = new Vector2 (x,y);
			Debug.Log ("jere");
		}
	}
}
