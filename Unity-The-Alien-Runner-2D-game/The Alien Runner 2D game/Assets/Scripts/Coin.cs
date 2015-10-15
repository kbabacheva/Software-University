using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
	HUD hud;
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			hud = GameObject.Find("Main Camera").GetComponent<HUD>();
			hud.IncreaseScore(1);
			Destroy(gameObject);
		}
	}
}
