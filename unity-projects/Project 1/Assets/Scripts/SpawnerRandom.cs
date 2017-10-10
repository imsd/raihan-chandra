using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerRandom : MonoBehaviour {

	public GameObject go;
	public GameObject go2;
	public GameObject go3;

	public float StartAfter = 1f;

	public float SpawnFrequency = .5f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnThing", StartAfter, SpawnFrequency);

	}

	// Update is called once per frame
	void SpawnThing () {

		transform.position = new Vector3 (Random.Range(-5,5), 3, Random.Range(-5,5));
		int RandomNumber = (int) Random.Range (0, 3);
		if (RandomNumber == 0) {
			Instantiate (go, transform.position, Quaternion.identity);
		}
		else if (RandomNumber == 1) {
			Instantiate (go2, transform.position, Quaternion.identity);
		}
		else {
			Instantiate (go3, transform.position, Quaternion.identity);
		}
	}
}
