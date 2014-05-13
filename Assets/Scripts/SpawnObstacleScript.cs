using UnityEngine;
using System.Collections;

public class SpawnObstacleScript : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 3f;
	private GameObject currentItem;
	private GameObject newItem;
	public Transform player;

	// Use this for initialization
	void Start () {
		currentItem = obj [Random.Range (0, obj.GetLength (0))];
		Instantiate (currentItem, transform.position, Quaternion.identity);
		//currentItem = item;
	}
	
	void Update()
	{
		var distanceFromPlayer = currentItem.transform.position.x - player.position.x;
		if (distanceFromPlayer <= 10f) {
			newItem = obj [Random.Range (0, obj.GetLength (0))];
			newItem.transform.position = new Vector3(currentItem.transform.position.x + 20f,currentItem.transform.position.y,0f);
			Instantiate (newItem, transform.position, Quaternion.identity);
			currentItem = newItem;
		}
	}
}
