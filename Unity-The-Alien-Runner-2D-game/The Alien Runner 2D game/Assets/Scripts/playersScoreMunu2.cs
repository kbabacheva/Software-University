using UnityEngine;
using System.Collections;

public class playersScoreMunu2 : MonoBehaviour {

	public GUISkin gSkin;
	
	void OnGUI()	{
		GUI.skin = gSkin;
		if (GUI.Button (new Rect ((Screen.width/2 - (Screen.width*0.1f)), 
		                          (Screen.height/2) - (Screen.height*0.45f), 
		                          Screen.width* 0.2f , 
		                          Screen.height* 0.1f), "Main Menu")) {
			Application.LoadLevel("MenuStart2");
		}
	}
}
