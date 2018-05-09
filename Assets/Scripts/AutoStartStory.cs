using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoStartStory : MonoBehaviour {

	public GameObject StoryIcon;
	public GameObject Story;

	public GameObject EndedWindow;
	public GameObject soundPlayer;
	public GameObject ImageCont;
	public GameObject SubCont;

	void Start () {
		if (SceneChanger.Value == 0)
		StartCoroutine (AutoStart());
	}
	
	IEnumerator AutoStart(){
		yield return new WaitForSeconds(1);
		StoryIcon.SetActive (false);
		Story.SetActive (true);
	}

	public void OnClickCloseBtn(){
		EndedWindow.SetActive (true);
		soundPlayer.GetComponent<Animator> ().Play ("SoundPlayerOff");
		ImageCont.GetComponent<Animator> ().Play ("ImageContainerOff");
		soundPlayer.SetActive (false);
		ImageCont.SetActive (false);
		SubCont.SetActive (false);
	}
}
