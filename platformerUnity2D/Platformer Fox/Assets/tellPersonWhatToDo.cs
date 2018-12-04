using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class tellPersonWhatToDo : MonoBehaviour {

	public GameObject panel;
	public Text text;
	public bool isCollider;

	void OnCollisionExit2D(Collision2D col)
	{
		isCollider = false;
	}
	void OnCollisionEnter2D (Collision2D col)
	{
		isCollider = true;
		string n = "Hey man you hit my barrier your supposed to go down the fucking hole. Thank You!";
		//Debug.Log (col.collider.name);
		if (col.collider.tag == "Player" && isCollider==true) {
			panel.SetActive (true);
			text.text = n;

		}
		if (isCollider == false) {
			panel.SetActive (false);
		}

	}
}
