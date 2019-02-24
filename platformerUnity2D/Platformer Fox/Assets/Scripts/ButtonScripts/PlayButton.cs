using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayButton : MonoBehaviour {
	public GameObject Panel;
	public GameObject Buttons;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void getRidOf()
	{
		Panel.SetActive (true);
		Buttons.SetActive (false);
	}

	public void backToMainMenu()
	{
		Panel.SetActive (false);
		Buttons.SetActive (true);
	}

	public void startLevel1()
	{
		SceneManager.LoadScene (1);
	}
}
