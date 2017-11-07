using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrayString : MonoBehaviour {

	public string[] names;
	public string[] places;
	public string[] foods;
	public string[] colors;
	public string[] clothes;


	void Start () {
		// loop thru all the names
		//        for (int i = 0; i < names.Length; i++) {
		//            Debug.Log (names [i]);
		//        }

		// draw a random name from the array
		//        int rando = Random.Range(0, names.Length);
		//        Debug.Log (names [rando]);

		// get a random number from 0 to the number of nouns available
		int randNoun = Random.Range(0, names.Length);
		int randPlace = Random.Range(0, places.Length);
		int randFood = Random.Range(0, foods.Length);
		int randColor = Random.Range(0, colors.Length);
		int randClothes = Random.Range(0, clothes.Length);

		string line1 = "One day, " + names [randNoun] +
		               " went to " + places [randPlace] + ". She was also really hungry and wanted to eat "
			+ foods [randFood] + ". She was wearing a " + colors [randColor] + " " + clothes [randClothes] + ".";

		// actually print out the madlib
		Debug.Log (line1);


	}

	// Update is called once per frame
	void Update () {

	}
}
