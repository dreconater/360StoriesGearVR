using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MouseLook : MonoBehaviour {
/*	private Touch initTouch = new Touch();

	public Camera cam;
	private float rotX;
	private float rotY;
	private Vector3 origRot;

	public float rotSpeed = 0.5f;
	public float dir = -1;

	void Start(){
		origRot = cam.transform.eulerAngles;
		rotX = origRot.x;
		rotY = origRot.y;
	}

	void FixedUpdate(){
		foreach (Touch touch in Input.touches) {
			if(touch.phase == TouchPhase.Began){
				initTouch = touch;
			}
			else if(touch.phase == TouchPhase.Moved){
				float deltaX = initTouch.position.x - touch.position.x;
				float deltaY = initTouch.position.y - touch.position.y;
				rotX -= deltaX * Time.deltaTime * rotSpeed * dir;
				rotY += deltaY * Time.deltaTime * rotSpeed * dir;
				rotY = Mathf.Clamp (rotY,-45f,45f);

				cam.transform.parent.eulerAngles = new Vector3 (rotY, rotX, 0);
			}
			else if(touch.phase == TouchPhase.Ended){
				initTouch = new Touch ();
			}
		}
	}*/




	Vector3 FirstPoint;
	Vector3 SecondPoint;
	float xAngle;
	float yAngle;
	float xAngleTemp;
	float yAngleTemp;

	void Start () {
		xAngle = 0;
		yAngle = 0;
		this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0);  

		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}

	void Update () {
		if (Input.touchCount > 0) {
			if (Input.GetTouch (0).phase == TouchPhase.Began) {
				FirstPoint = Input.GetTouch (0).position;
				xAngleTemp = xAngle;
				yAngleTemp = yAngle;
			}
			if (Input.GetTouch (0).phase == TouchPhase.Moved) {
				SecondPoint = Input.GetTouch (0).position;
				xAngle = xAngleTemp + (SecondPoint.x - FirstPoint.x) * 180 / Screen.width;
				yAngle = yAngleTemp + (SecondPoint.y - FirstPoint.y) * 90 / Screen.height;
				yAngle = Mathf.Clamp (yAngle,-45f,45f);
				transform.rotation = Quaternion.Euler (yAngle, -xAngle, 0.0f);
			}
		}


	}
}
