using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerExit(Collider other){
		if ("Bolt".Equals(other.gameObject.tag)) {
			Destroy (other.gameObject);
		}
	}
}
