using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {
	int playerScore;
	public Texture playersHealthTexture;
	public float screenPosX;
	public float screenPosY;
	public float iconSizeX = 25;
	public float iconSizeY = 25;
	public float playersHealth = 3f;
	float takenDamage = 0.2f;

	public void IncreaseScore(int amout){
		playerScore += amout;
		}

	public void DecreaseLifes(float amout){
		playersHealth -= amout;
		if (playersHealth == 0) {
			Application.LoadLevel(2);
				}
	}

	public void IncreaseLifes(float amout){
		playersHealth += amout;
	}
	
	public void RestartScene()
	{ 
		Application.LoadLevel (Application.loadedLevel);
	}

	void OnDisable() {
		PlayerPrefs.SetInt ("Score", (int)playerScore);
		}

	void OnGUI(){
		
		GUIStyle style = new GUIStyle ();
		style.font = (Font)Resources.Load ("font6", typeof(Font));
		style.fontSize = 30;
		style.normal.textColor = Color.black;
		GUI.Label (new Rect(800,1,1,1),"score: " + playerScore,style);
		for (int h = 0; h < playersHealth; h++) 
		{
			GUI.DrawTexture(new Rect(screenPosX+(h*iconSizeX),screenPosY,iconSizeX,iconSizeY),playersHealthTexture,ScaleMode.ScaleToFit,true,0);
		}
	}
}
