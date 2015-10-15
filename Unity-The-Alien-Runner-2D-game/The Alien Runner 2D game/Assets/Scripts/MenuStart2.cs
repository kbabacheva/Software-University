using UnityEngine;
using System.Collections;

public class MenuStart2 : MonoBehaviour {

	public GUISkin gSkin;


	void OnGUI()	{
		GUI.skin = gSkin;
		if (GUI.Button (new Rect ((Screen.width/2 - (Screen.width*0.1f)), 
		                          (Screen.height/2) - (Screen.height*0.25f), 
		                          Screen.width* 0.2f , 
		                          Screen.height* 0.1f), "Play Game")) {
			Application.LoadLevel("Level1");

		}

		if (GUI.Button (new Rect ((Screen.width/2 - (Screen.width*0.1f)), 
		                          (Screen.height/2) - (Screen.height*0.13f), 
		                          Screen.width* 0.2f , 
		                          Screen.height* 0.1f), "High Score")) {
			Application.LoadLevel("playersScores");
		}

		if (GUI.Button (new Rect ((Screen.width/2 - (Screen.width*0.1f)), 
		                          (Screen.height/2) - (Screen.height*0.01f), 
		                          Screen.width* 0.2f , 
		                          Screen.height* 0.1f), "Quite Game")) {
			Application.Quit();
		}
	}
}
 