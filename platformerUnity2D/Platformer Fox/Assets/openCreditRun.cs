using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openCreditRun : MonoBehaviour {
	public Transform target;
	public Transform startPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float step = 10 * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target.position, step);
		if (transform.position.y == target.position.y) {
			transform.position = new Vector3 (startPos.transform.position.x, startPos.transform.position.y, startPos.transform.position.z);
		}
	}
}
