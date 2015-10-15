using UnityEngine;
using System.Collections;

public class LifesSpawn : MonoBehaviour {
	public GameObject obj;
	void Start () {
		SpawningLife ();
	}
	void SpawningLife(){
		Instantiate (obj, new Vector3(transform.position.x, transform.position.y+Random.Range(0,5), transform.position.z), Quaternion.identity);
		Invoke ("SpawningLife",20);
	}
}
