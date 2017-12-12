﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetWeather : MonoBehaviour {
	// check here for weather stats
	// https://www.metaweather.com/api/

	public GameObject LightRain;
	public GameObject LightCloud;
	public GameObject HeavyCloud;
	public GameObject HeavyRain;
	public GameObject Showers;
	public GameObject LightSnow;
	public GameObject HeavySnow;

	public string url = "https://www.metaweather.com/api/location/2459115/";
	IEnumerator Start() {

		// fetch the actual info, like you would from a browser
		WWW www = new WWW(url);

		// yield return waits for the download to complete before proceeding
		// but since this is in IEnumerator it wont stall the program outright
		yield return www;

		// use a JSON Object to store the info temporarily
		// this makes it easy to access the data struture
		JSONObject tempData = new JSONObject (www.text);

		// this particular API stores all the data under the header
		// "consolidated_weather" so first get in there
		JSONObject weatherDetails = tempData["consolidated_weather"];

		// log it just to see whats up
		Debug.Log (weatherDetails.ToString());

		// now we can do cool stuff like...
		string WeatherType = weatherDetails[0]["weather_state_name"].str;
		Debug.Log (WeatherType);

		if (WeatherType == "Heavy Cloud") {
			HeavyCloud.SetActive (true);
		}
		if (WeatherType == "Light Cloud") {
			LightCloud.SetActive (true);
		}
		if (WeatherType == "Light Rain") {
			LightRain.SetActive (true);
		}
		if (WeatherType == "Heavy Rain") {
			HeavyRain.SetActive (true);
		}
		if (WeatherType == "Showers") {
			Showers.SetActive (true);
		}
		if (WeatherType == "Light Snow") {
			LightSnow.SetActive (true);
		}
		if (WeatherType == "Heavy Snow") {
			HeavySnow.SetActive (true);
		}
	}
}
