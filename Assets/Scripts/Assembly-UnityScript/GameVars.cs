using System;
using UnityEngine;

[Serializable]
public class GameVars : MonoBehaviour
{
	[NonSerialized]
	public static bool multiplayer;

	[NonSerialized]
	public static int Player1Character;

	[NonSerialized]
	public static int Player2Character = 2;

	public bool multiplayerpoo;

	[NonSerialized]
	public static int AIdifficulty = 20;

	public void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(transform.gameObject);
	}
	public void Update(){
		multiplayerpoo = multiplayer;
	}
}
