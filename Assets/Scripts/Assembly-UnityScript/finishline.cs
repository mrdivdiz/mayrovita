using System;
using UnityEngine;

[Serializable]
public class finishline : MonoBehaviour
{
	public int latestpasser;

	public AudioClip[] PassClips;

	public void OnTriggerEnter(Collider Playerboy)
	{
		if (Playerboy.gameObject.CompareTag("Player1"))
		{
			gamecontroller.latestplayerpass = 1;
		}
		if (Playerboy.gameObject.CompareTag("Player2"))
		{
			gamecontroller.latestplayerpass = 2;
		}
		Playerboy.gameObject.SendMessage("passing", SendMessageOptions.DontRequireReceiver);
		int num = UnityEngine.Random.Range(0, 1);
	}
}
