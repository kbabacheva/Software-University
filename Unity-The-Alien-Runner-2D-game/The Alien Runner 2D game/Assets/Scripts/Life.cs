using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {
	HUD hud;
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			hud = GameObject.Find("Main Camera").GetComponent<HUD>();
			hud.IncreaseLifes(1);
			Destroy(gameObject);
		}
	}
}
