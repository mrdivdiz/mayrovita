using System;
using UnityEngine;

[Serializable]
[AddComponentMenu("Camera-Control/Smooth Follow")]
public class SmoothFollow : MonoBehaviour
{
	public Transform target;

	public float distance;

	public float height;

	public float heightDamping;

	public float rotationDamping;

	public SmoothFollow()
	{
		distance = 10f;
		height = 5f;
		heightDamping = 2f;
		rotationDamping = 3f;
	}

	public void LateUpdate()
	{
		if ((bool)target)
		{
			Vector3 eulerAngles = target.eulerAngles;
			float y = eulerAngles.y;
			Vector3 position = target.position;
			float to = position.y + height;
			Vector3 eulerAngles2 = transform.eulerAngles;
			float y2 = eulerAngles2.y;
			Vector3 position2 = transform.position;
			float y3 = position2.y;
			y2 = Mathf.LerpAngle(y2, y, rotationDamping * Time.deltaTime);
			y3 = Mathf.Lerp(y3, to, heightDamping * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(0f, y2, 0f);
			transform.position = target.position;
			transform.position -= rotation * Vector3.forward * distance;
			float y4 = y3;
			Vector3 position3 = transform.position;
			float num = position3.y = y4;
			Vector3 vector2 = transform.position = position3;
			transform.LookAt(target);
		}
	}
}
