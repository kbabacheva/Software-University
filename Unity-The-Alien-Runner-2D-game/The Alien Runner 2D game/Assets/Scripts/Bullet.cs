using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	HUD hud;
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Enemy") {
			Destroy(gameObject);
			Destroy(other.gameObject);
			hud = GameObject.Find("Main Camera").GetComponent<HUD>();
			hud.IncreaseScore(5);
		}
	}
}
