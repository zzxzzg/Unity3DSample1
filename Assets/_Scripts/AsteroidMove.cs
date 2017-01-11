using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMove : MonoBehaviour {
	public float rate =10.0f;
	// Use this for initialization
	void Start () {
		Random.InitState (System.DateTime.Today.Millisecond);
		GetComponent<Rigidbody> ().angularVelocity = Random.insideUnitSphere * rate;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
