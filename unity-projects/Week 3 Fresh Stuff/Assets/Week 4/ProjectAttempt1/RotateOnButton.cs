using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnButton : MonoBehaviour {
	
	public Vector3 myRotation;
	public Vector3 myRotation2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey("r")) {
			// rotate one way
			transform.Rotate(myRotation * Time.deltaTime);
		}
		if (Input.GetKey("e")) {
			// rotate the other way
			transform.Rotate(myRotation2 * Time.deltaTime);
		}

		
	}
}
