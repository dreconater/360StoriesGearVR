using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;


public class VideoEnding : MonoBehaviour {

	public string SceneName;

	void Start () {
		StartCoroutine (waitSec ());
	}
	
	// Update is called once per frame
	public void OnClickBtn () {

			SceneChanger.Value = 1;
			SceneManager.LoadScene (SceneName);

	}

	IEnumerator waitSec(){
		yield return new WaitForSeconds (4);
		SceneChanger.Value = 1;
		SceneManager.LoadScene (SceneName);
		
	}
}
