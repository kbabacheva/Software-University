using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
	public GameObject[] obj;
	int spawnFrequency = 5;
	void Start () {
		Spawning ();
	}
	void Spawning(){
		Instantiate (obj [Random.Range (0, obj.GetLength(0))], new Vector3(transform.position.x, transform.position.y+Random.Range(0,5), transform.position.z), Quaternion.identity);
		Invoke ("Spawning",spawnFrequency);
     }
}
