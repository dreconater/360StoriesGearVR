using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour {

	AudioSource audioSource;
	int musicTime = 0;
	public AudioClip[] clipNames;
	public Slider musicLength;
	private bool stop = false;

	public Sprite playImage;
	public Sprite stopImage;
	public Sprite volumeUpImage;
	public Sprite volumeDownImage;

	public Image playStopButton;
	public Image VolumeButton;
	public Text AudioTime;
	public Text AudioLength;
	public GameObject retroPic;


	public void Start () {
		audioSource = GetComponent<AudioSource> ();
		StartAudio ();
		playStopButton.sprite = stopImage;
		VolumeButton.sprite = volumeUpImage;
	}
	
	// Update is called once per frame
	void Update () {
		if (!stop) {
			musicLength.value += Time.deltaTime;
		}
		float x = audioSource.time;
		float y = audioSource.clip.length;
		AudioTime.text = "00:"+ Mathf.Round(x);
		AudioLength.text = "00:" +Mathf.Round(y);

		if (audioSource.time > 52.2) {
			playStopButton.sprite = playImage;
		}
	}
	public void StartAudio () {
		audioSource.clip = clipNames [musicTime];
		musicLength.maxValue = audioSource.clip.length;
		musicLength.value = 0;
		audioSource.Play ();
	}

	public void PlayPauseButton() {
		if (playStopButton.sprite == stopImage) {
			audioSource.Pause();
			playStopButton.sprite = playImage;
			stop = true;
		} else {
			audioSource.Play();

			playStopButton.sprite = stopImage;
			retroPic.SetActive (false);
			stop = false;
			if(audioSource.time == 0)
			{
				musicLength.value = 0;
			}
		}
	}

	public void volumeButton() {
		if (VolumeButton.sprite == volumeUpImage) {
			audioSource.mute = true;
			VolumeButton.sprite = volumeDownImage;
		} else {
			audioSource.mute = false;
			VolumeButton.sprite = volumeUpImage;
		}
	}

}
