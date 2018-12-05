using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingScript : MonoBehaviour {


	Vector2 tempPos;

	public GameObject platForm;
	public GameObject startPoint;
	public GameObject endPoint;
	public float speedOfPlatform;

	bool isOnEndPoint = false;

	// Use this for initialization
	void Start () 
	{
		tempPos = platForm.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (isOnEndPoint == false) {
			tempPos.x += speedOfPlatform;
			platForm.transform.position = tempPos;
			if (tempPos.x >= endPoint.transform.position.x) {
				isOnEndPoint = true;
			}
		} 
		else 
		{
			tempPos.x -= speedOfPlatform;
			platForm.transform.position = tempPos;
			if (tempPos.x <= startPoint.transform.position.x) 
			{
				isOnEndPoint = false;
			}
		}

	}
}
