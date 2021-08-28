
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class gamecontroller : MonoBehaviour
{

	[NonSerialized]
	public static int laps = 1;

	[NonSerialized]
	public static int latestplayerpass;

	public Camera MainCamera;

	public Camera WinCamera1;

	public Camera WinCamera2;

	public Camera Player1Camera;

	public Camera Player2Camera;
	
	public GUIText GuiText;

	//[NonSerialized]
	private bool multiplayer;
	
	public bool testmp;

	private bool GameIsOver;
	
	void Start(){
		multiplayer = GameVars.multiplayer;
		testmp = multiplayer;
		if (multiplayer)
			{
				MainCamera.enabled = false;
				Player1Camera.enabled = true;
				Player2Camera.enabled = true;
			}else{
				MainCamera.enabled = true;
				Player1Camera.enabled = false;
				Player2Camera.enabled = false;
			}
	}

	public void passed(int passnumber)
	{
		if (passnumber > laps - 1)
		{
			laps++;
		}
		if (laps > 3)
		{
			GameIsOver = true;
			MonoBehaviour.print("GameOver");
			if (latestplayerpass == 1)
			{
				kartkontrol.AI = true;
				WinCamera1.enabled = true;
				GetComponent<GUIText>().text = "player 1 has winned!";
			}
			if (latestplayerpass == 2)
			{
				kartkontrolplayer2.AI = true;
				WinCamera2.enabled = true;
				GetComponent<GUIText>().text = "player 2 has winned!";
			}
			MainCamera.enabled = false;
			if (multiplayer)
			{
				Player1Camera.enabled = false;
				Player2Camera.enabled = false;
			}
		}
	}

	public void Update()
	{
		if (!GameIsOver)
		{
			GetComponent<GUIText>().text = "lappe " + laps + "/3";
		}
	}

}
