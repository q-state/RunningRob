using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 3f;

	// Use this for initialization
	void Start () {
		Spawn ();
	}

	void Spawn()
	{
		var item = obj [Random.Range (0, obj.GetLength (0))];
		if (item.tag == "Obstacle") {
			Instantiate (item, transform.position, Quaternion.identity);
					
				} else {
			Instantiate (item, transform.position, Quaternion.identity);
				}
		Invoke ("Spawn", 1.3f);
	}
}
