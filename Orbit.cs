using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

	public float e; // Eccentricity
	public float a; // Semi-Major Axis
	float b; // Semi-Minor Axis
	public float rotSpeed;
	
	public Transform orbitCenter;

	float timer = 0;
	
	// Update is called once per frame
	void Update () 
	{
		timer += (Time.deltaTime) * rotSpeed; // Time.deltaTime is the interval in seconds from the last frame to the current one 
		Debug.Log(timer);
		// Program kepler's laws, speed is not going to be constant
		Rotate();		
	}

	void Rotate() 
	{
		b = Mathf.Sqrt(Mathf.Pow(a, 2)*(1 - Mathf.Pow(e, 2))); // Calculates the Semi-Minor Axis
		float x = Mathf.Cos(timer) * a;
		float z = Mathf.Sin(timer) * a; // * b;
		Vector3 pos = new Vector3(x, 0, z);
		transform.position = pos + orbitCenter.position;
		Debug.Log(pos);
	}
}