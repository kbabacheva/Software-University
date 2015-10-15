using UnityEngine;
using System.Collections;

public class CoinSpawn : MonoBehaviour {
	public float spawnMin = 1f;
	public float spawnMax = 5f;
	 public GameObject obj;
		void Start () {
			SpawningCoin ();
		}
		void SpawningCoin(){
		Instantiate (obj, new Vector3(transform.position.x, transform.position.y+Random.Range(0,5), transform.position.z), Quaternion.identity);
			Invoke ("SpawningCoin",Random.Range(spawnMin,spawnMax));
	}
}
