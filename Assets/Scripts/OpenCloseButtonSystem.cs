using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenCloseButtonSystem : MonoBehaviour {
	public GameObject Story;
	public GameObject Pic;
	public GameObject SubCont;
	public MusicPlayer myscript;

	public Image image1;
	public Image image2;
	public Image image3;
	public Image image4;
	public GameObject retroImage;

	public GameObject SubRow1;
	public GameObject SubRow2;
	public GameObject SubRow3;
	public GameObject SubRow4;
	public GameObject SubRow5;
	public GameObject SubRow6;
	public GameObject SubRow7;
	public GameObject SubRow8;
	public GameObject SubRow9;
	public GameObject SubRow10;
	public GameObject SubRow11;
	public GameObject SubRow12;
	public GameObject SubRow13;

	public void OnButtonClick(){
		float Image1PosX = -14.16f;
		float Image1PosY = -6.216667f;
		float Image1SizeX = 7.844f;
		float Image1SizeY = 5.647f;

		float Image2PosX = -4.774001f;
		float Image2PosY = -6.216666f;
		float Image2SizeX = 7.844f;
		float Image2SizeY = 5.647f;

		float Image3PosX = 4.487f;
		float Image3PosY = -6.216666f;
		float Image3SizeX = 7.844f;
		float Image3SizeY = 5.647f;

		float Image4PosX = 13.906f;
		float Image4PosY = -6.216666f;
		float Image4SizeX = 7.844f;
		float Image4SizeY = 5.647f;
		
	if (Story.activeInHierarchy == false) {
			Pic.SetActive (false);
			Story.SetActive (true);
			myscript.StartAudio();


		} else {
			Pic.SetActive (true);
			retroImage.SetActive (false);
			Story.SetActive (false);

			SubRow1.SetActive (false);
			SubRow2.SetActive (false);
			SubRow3.SetActive (false);
			SubRow4.SetActive (false);
			SubRow5.SetActive (false);
			SubRow6.SetActive (false);
			SubRow7.SetActive (false);
			SubRow8.SetActive (false);
			SubRow9.SetActive (false);
			SubRow10.SetActive (false);
			SubRow11.SetActive (false);
			SubRow12.SetActive (false);
			SubRow13.SetActive (false);

			image1.rectTransform.anchoredPosition = new Vector2(Image1PosX,Image1PosY);
			image1.rectTransform.sizeDelta = new Vector2 (Image1SizeX,Image1SizeY);
			image2.rectTransform.anchoredPosition = new Vector2(Image2PosX,Image2PosY);
			image2.rectTransform.sizeDelta = new Vector2 (Image2SizeX,Image2SizeY);
			image3.rectTransform.anchoredPosition = new Vector2(Image3PosX,Image3PosY);
			image3.rectTransform.sizeDelta = new Vector2 (Image3SizeX,Image3SizeY);
			image4.rectTransform.anchoredPosition = new Vector2(Image4PosX,Image4PosY);
			image4.rectTransform.sizeDelta = new Vector2 (Image4SizeX,Image4SizeY);
		}
	}

}
