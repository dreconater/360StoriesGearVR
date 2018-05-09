using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckingBookFields : MonoBehaviour {

	public Text EmailField;
	public Text PhoneField;

	public Toggle EmailCheck;
	public Toggle PhoneCheck;

	public Button BookNow;

	void Start(){
		BookNow.enabled = false;
	}

	void FixedUpdate () {
		if(PhoneField.text.Length == 9){
			PhoneCheck.isOn = true;
		}
		if(EmailField.text.IndexOf('@') >= 1){
			EmailCheck.isOn = true;
		}

		if (EmailCheck.isOn == true || PhoneCheck.isOn == true) {
			BookNow.enabled = true;
			BookNow.image.color = new Color32 (60,212,150,255);
		}
	}

}
