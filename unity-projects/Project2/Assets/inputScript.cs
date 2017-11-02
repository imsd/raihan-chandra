﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class inputScript : MonoBehaviour {

	public string WhichKey;	// which key will activate it?

	// sound stuff
	AudioSource audioSource;

	// the renderer for this cube
	public Renderer rend;

	public Color myColor;

	void Start () {

		// at start, get the Renderer component of this object
		// and set it to rend
		rend = GetComponent<Renderer> ();

		// and audio source
		audioSource = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (WhichKey)) {

			// make sure its not already playing
			if (audioSource.isPlaying == false) {
				audioSource.Play ();
			}

			// turn it a different color
			rend.material.color = myColor;
		} if (Input.GetKeyUp (WhichKey)) {
			audioSource.Stop ();
			rend.material.color = Color.black;
		}

	}
}