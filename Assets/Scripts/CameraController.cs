using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	//GameObject camParent;

	void Start (){
		//camParent = new GameObject ("camParent");
		//camParent.transform.position = this.transform.position;
		//this.transform.parent = camParent.transform;
		Input.gyro.enabled = true;
	}

	void Update (){
		transform.Rotate (0,-Input.gyro.rotationRateUnbiased.y,0);
		transform.Rotate (-Input.gyro.rotationRateUnbiased.x,0,0);
	}
}
