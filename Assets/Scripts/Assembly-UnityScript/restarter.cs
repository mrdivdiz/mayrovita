using System;
using UnityEngine;

[Serializable]
public class restarter : MonoBehaviour
{
	public Transform respawnpoint;

	public void OnTriggerEnter(Collider Turder)
	{
		Turder.gameObject.transform.position = respawnpoint.position;
		Turder.gameObject.transform.rotation = respawnpoint.rotation;
	}


}
