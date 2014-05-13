using UnityEngine;
using System.Collections;

public class GroundSpawner : MonoBehaviour {

	public GameObject Ground;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		var player = (GameObject)GameObject.Find ("2D Character");

		if (player.transform.position.x == gameObject.transform.position.x) {
			var groundSpawn = GetComponent<SpawnScript>();
			groundSpawn.Spawn();
		}
	}
}
