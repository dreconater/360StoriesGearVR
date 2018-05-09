using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationLikeScript : MonoBehaviour {
	public Image Hearth;
	public int Likes;
	public Text LikesText;
	public Text word;

	public Image VoiceIcon;
	public Sprite VoiceIconDeActive;
	public Sprite VoiceIconActive;



	// Use this for initialization
	void Start () {
		Likes = 10;
		LikesText.text = Likes.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClickHearth() {
		if (Hearth.color == Color.white){
			Hearth.color = Color.red;
			Likes = Likes + 1;
			LikesText.text = Likes.ToString();
			LikesText.color = Color.red;
			word.color = Color.red;
		} else {
			Hearth.color = Color.white;
			Likes = Likes - 1;
			LikesText.text = Likes.ToString();
			LikesText.color = Color.grey;
			word.color = Color.grey;
		}

	}

	public void OnClickVoice(){
		if (VoiceIcon.sprite == VoiceIconDeActive) {
			VoiceIcon.sprite = VoiceIconActive;
		} else {
			VoiceIcon.sprite = VoiceIconDeActive;
		}
	}
}
