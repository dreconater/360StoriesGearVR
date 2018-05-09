using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour {
	// Use this for initialization

	public static int Value = 0;
	public void OnBtnClick (string Scene) {
		Value = 0;
		SceneManager.LoadScene(Scene);
	}

	public void OnExitBtnClick (string Scene) {
		
		SceneManager.LoadScene(Scene);

	}
	public void OnBackBtnClick (string Scene) {
		SceneChanger.Value = 1;
		SceneManager.LoadScene(Scene);

	}


}
