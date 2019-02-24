using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoadScript : MonoBehaviour {

	public void startLevelOne()
	{
		SceneManager.LoadScene (1);
	}
}
