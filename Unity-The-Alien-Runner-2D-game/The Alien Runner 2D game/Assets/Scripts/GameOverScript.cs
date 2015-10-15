using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {
	int score = 0;
	string playersName = "";
	
	void Start () {
		score = PlayerPrefs.GetInt("Score");
	}
	void OnGUI () {
		GUI.Label(new Rect(Screen.width / 2 - 40, 50, 80, 30), "GAME OVER");
		GUI.Label (new Rect (Screen.width / 2  - 40, 180, 80, 30), "Name:");
		playersName = GUI.TextField ( new Rect (Screen.width / 2 - 0, 180, 80, 30), playersName);
		GUI.Label(new Rect(Screen.width / 2 -28, 150, 80, 30), "Score: " + score);
		if (GUI.Button(new Rect(Screen.width / 2 -60, 220, 120, 30), "Save")) {
			if(playersName.Length > 0){
				string names = PlayerPrefs.GetString("Names");
				string scores = PlayerPrefs.GetString("Scores");
				scores += score.ToString() + "\n";
				names += playersName + "\n";
				PlayerPrefs.SetString("Scores",scores);
				PlayerPrefs.SetString("Names",names);
				PlayerPrefs.Save();
				//PlayerPrefs.DeleteAll();
				Application.LoadLevel("playersScores");
			}
		}
		if (GUI.Button(new Rect(Screen.width / 2 -60, 250, 120, 30), "Play Again?")) {
			Application.LoadLevel(1);
		}
		
	}
}
