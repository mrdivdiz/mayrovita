using System;
using UnityEngine;

[Serializable]
public class jumppad : MonoBehaviour
{
	public float upForce;

	public void OnTriggerEnter(Collider Turd)
	{
		Turd.GetComponent<Rigidbody>().AddForce(Vector3.up * upForce);
	}
}
