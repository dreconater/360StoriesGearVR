using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

	public GameObject SoundPlayer;
	public GameObject ImageCont;
	public GameObject EndedWindow;
	public GameObject StoryIcon;

	void Start () {
		if(SceneChanger.Value == 1){
			ShowWindow ();
		}
	}
	
	// Update is called once per frame
	public void ShowWindow(){
		ImageCont.SetActive (false);
		SoundPlayer.SetActive (false);
		EndedWindow.SetActive (true);
		StoryIcon.SetActive (false);
	}
}
