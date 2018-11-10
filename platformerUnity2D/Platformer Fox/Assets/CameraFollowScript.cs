using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour {

	private Vector2 velocity;

	public float smoothTimeY;
	public float smoothTimeX;

	private GameObject target;
	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player");
	}
	

	void FixedUpdate ()
	{
		float posX = Mathf.SmoothDamp (transform.position.x, target.transform.position.x, ref velocity.x, smoothTimeX);
		float posY = Mathf.SmoothDamp (transform.position.y, target.transform.position.y, ref velocity.y, smoothTimeY);

		transform.position = new Vector3 (posX, posY, transform.position.z);

	}

}
