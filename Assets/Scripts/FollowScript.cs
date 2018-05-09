using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FollowScript : MonoBehaviour {

	/*public Transform target;


	public float smoothSpeed = 4f;


	void FixedUpdate ()
	{
		transform.position = Vector3.Lerp(transform.position,target.position, smoothSpeed);
		transform.rotation = target.rotation;
	}*/


	[SerializeField] private float damp;
	public Transform cameraTransform;


	Quaternion rotation;
	[SerializeField] private bool forceSet = false;
	[SerializeField] private float deltaAngle = 30.0f;

	private float stopVar = 0;

	void Awake()
	{
		cameraTransform = cameraTransform.transform;
	}

	public void Update()
	{
		if (stopVar == 0)
		{
		if (!forceSet)
		{
			if (Mathf.Abs(cameraTransform.rotation.eulerAngles.y - rotation.eulerAngles.y) > deltaAngle)
			{
				rotation = Quaternion.Lerp(rotation, cameraTransform.rotation, damp * Time.deltaTime);
			}
		}
		else
		{
			rotation = cameraTransform.rotation;
		}

		float rotationY = rotation.eulerAngles.y;
		transform.rotation = Quaternion.Euler(0.0f, rotationY, 0.0f);
		}



	}

	public void Stop()
	{
		stopVar = 1;

	}

	public void Move()
	{
		stopVar = 0;

	}
}

