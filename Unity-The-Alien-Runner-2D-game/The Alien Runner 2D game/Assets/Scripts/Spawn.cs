using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	public GameObject[] obj;
	public float spawn = 4f;
	// Use this for initialization
	void Start () {
		Spawning ();
	}


	void Spawning(){
		Instantiate (obj [Random.Range (0, obj.GetLength(0))], transform.position, Quaternion.identity);
		Invoke ("Spawning",spawn);
	}
}
