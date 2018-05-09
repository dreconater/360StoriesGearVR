using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerScript : MonoBehaviour {
	public GameObject Panel_info; 
	public GameObject Pic; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onClickBtn(){
		if (Panel_info.activeInHierarchy == false) {
			Panel_info.SetActive (true);
			Pic.SetActive (false);
		} else {
			Panel_info.SetActive (false);
			Pic.SetActive (true);
		}

	}
}
