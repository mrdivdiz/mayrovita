using System;
using UnityEngine;

[Serializable]
public class settings : MonoBehaviour
{
	public string[] characterStrings;

	public int Player1;

	public int LevelSelectionVar;

	public string[] LevelSelectionStrings;

	public settings()
	{
		characterStrings = new string[3]
		{
			"mayro",
			"luggy",
			"joshy"
		};
		Player1 = 2;
		LevelSelectionStrings = new string[2]
		{
			"dessert rumble",
			"musshrom villadge"
		};
	}

	public void OnGUI()
	{
		GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2, 400f, 200f), "setting");
		GUI.Label(new Rect(Screen.width / 2 - 100 + 10, Screen.height / 2 + 20, 100f, 20f), "track:");
		LevelSelectionVar = GUI.Toolbar(new Rect(Screen.width / 2 - 100 + 50, Screen.height / 2 + 20, 300f, 20f), LevelSelectionVar, LevelSelectionStrings);
		GUI.Label(new Rect(Screen.width / 2 - 100 + 10, Screen.height / 2 + 50, 100f, 20f), "player:");
		GameVars.Player1Character = GUI.Toolbar(new Rect(Screen.width / 2 - 100 + 60, Screen.height / 2 + 50, 300f, 20f), GameVars.Player1Character, characterStrings);
		GUI.Label(new Rect(Screen.width / 2 - 100 + 10, Screen.height / 2 + 80, 100f, 20f), "player2:");
		GameVars.Player2Character = GUI.Toolbar(new Rect(Screen.width / 2 - 100 + 60, Screen.height / 2 + 80, 300f, 20f), GameVars.Player2Character, characterStrings);
		GameVars.multiplayer = GUI.Toggle(new Rect(Screen.width / 2 - 100 + 30, Screen.height / 2 + 110, 100f, 20f), GameVars.multiplayer, "multiplayer");
		GUI.Label(new Rect(Screen.width / 2 - 100 + 170, Screen.height / 2 + 110, 300f, 20f), "playre 1 move: LS break: LB");
		GUI.Label(new Rect(Screen.width / 2 - 100 + 170, Screen.height / 2 + 130, 300f, 20f), "playre 2 move: RS break: RB");
		GUI.Label(new Rect(Screen.width / 2 - 100 + 170, Screen.height / 2 + 155, 300f, 20f), "ai difficulty:");
		GameVars.AIdifficulty = (int)GUI.HorizontalSlider(new Rect(Screen.width / 2 - 100 + 170, Screen.height / 2 + 170, 100f, 30f), GameVars.AIdifficulty, 1f, 50f);
		if (GUI.Button(new Rect(Screen.width / 2 - 100 + 30, Screen.height / 2 + 150, 100f, 20f), "play"))
		{
			if (LevelSelectionVar == 0)
			{
				Application.LoadLevel(1);
			}
			if (LevelSelectionVar == 1)
			{
				Application.LoadLevel(2);
			}
		}
	}


}
