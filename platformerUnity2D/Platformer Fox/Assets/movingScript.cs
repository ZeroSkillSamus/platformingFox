using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingScript : MonoBehaviour {

	Vector3 tempPos;
	public GameObject platForm;
	public GameObject startPoint;
	public GameObject endPoint;
	bool isOnEndPoint = false;
	// Use this for initialization
	void Start () 
	{
		tempPos = startPoint.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isOnEndPoint == false) {
			tempPos.x += .1f;
			platForm.transform.position = tempPos;
			if (tempPos.x >= endPoint.transform.position.x) {
				isOnEndPoint = true;
			}
		} 
		else 
		{
			tempPos.x -= .1f;
			platForm.transform.position = tempPos;
			if (tempPos.x <= startPoint.transform.position.x) 
			{
				isOnEndPoint = false;
			}
		}
	}
}
