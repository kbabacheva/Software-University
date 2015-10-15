using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {
	HUD hud;
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			hud = GameObject.Find("Main Camera").GetComponent<HUD>();
            // after character die load the scene number...
			Application.LoadLevel(2);
			return;
		}

		if (other.gameObject.transform.parent) {
			Destroy(other.gameObject.transform.parent.gameObject);
		}

		else {
			Destroy(other.gameObject);
				}
	}
}
