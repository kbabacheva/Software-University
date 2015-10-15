using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	float damage = 0.5f;
	HUD hud;
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Player")
		{	
			hud = GameObject.Find("Main Camera").GetComponent<HUD>();
			hud.DecreaseLifes(damage);
		//	yield return new WaitForSeconds(2); 
		}		
	}

}
