using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

	public Rigidbody2D bulletPrefab;
	float attackRate = 0.1f;
	float coolDown;
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= coolDown) {
			if (Input.GetKeyDown (KeyCode.LeftAlt)) {
				BulletAttack();
			}
		}

		if (Time.time >= coolDown) {
			if (Input.GetKeyDown (KeyCode.RightAlt)) {
				BulletAttack();
			}
		}
	}

	void BulletAttack(){
		Rigidbody2D bPrefab =  Instantiate (bulletPrefab, transform.position, Quaternion.identity) as Rigidbody2D;
		bPrefab.rigidbody2D.AddForce (Vector3.right * 500);
		coolDown = Time.time + 5*attackRate;
	}
}
