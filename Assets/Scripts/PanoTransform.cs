using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanoTransform : MonoBehaviour {




	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float width = Screen.width / Screen.width*2;
		float height = Screen.height / Screen.height;
		transform.localScale = new Vector3 (width,height,1);
	}




}
