using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnHover : MonoBehaviour {

	// rotation variable
	public Vector3 myRotation;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void OnMouseOver() {
		transform.Rotate(myRotation * Time.deltaTime);
	}
}
