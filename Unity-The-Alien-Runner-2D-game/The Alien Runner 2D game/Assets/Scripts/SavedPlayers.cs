using UnityEngine;
using System.Collections;

public class SavedPlayers : MonoBehaviour {
	string names;
	string scores;
	string playersName = "";
	float xNames = 40f;
	float xScore = 80f;
	void Start () {
		scores = PlayerPrefs.GetString ("Scores");
		names = PlayerPrefs.GetString("Names");
	}
	
	void OnGUI () {
		
		GUI.Label(new Rect(200,100,100,350),names);
		GUI.Label(new Rect(300,100,100,350),scores);
		if (GUI.Button(new Rect(Screen.width / 2 -60, 400, 120, 30), "Play Again?")) {
			Application.LoadLevel(1);
		}
	}
}
