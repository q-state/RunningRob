using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject InitialGround;
	public GameObject Player;
	public GameObject[] Grounds;
	public float spawnMin = 1f;
	public float spawnMax = 3f;

	private GameObject currentGround;

	// Use this for initialization
	void Start () {
		SpawnInitial ();
	}

	public void Spawn()
	{
		var item = Grounds [Random.Range (0, Grounds.GetLength (0))];
		var newPosition = new Vector3 (currentGround.transform.position.x + currentGround.renderer.bounds.size.x, 0f);
		currentGround = (GameObject)Instantiate(item, newPosition, Quaternion.identity);
	}

	void SpawnInitial()
	{
		var designerGround1 = GameObject.Find ("Ground1");
		Destroy (designerGround1);

		var initialPosition = new Vector3 (2f, 0f);
		currentGround = (GameObject)Instantiate(InitialGround, initialPosition, Quaternion.identity);
	}
}
