using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidContacts : MonoBehaviour {
	public GameObject explosion;
	public GameObject playerExplosion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		print ("OnTriggerEnter");
		if (other.gameObject.tag == "Boundary") {
			return;
		}

		Instantiate (explosion, transform.position, transform.rotation);
		if (other.gameObject.tag == "Player") {
			GameObject obj = Instantiate (playerExplosion, transform.position, transform.rotation);
			//obj.GetComponent<ParticleSystem>().IsAlive
		}



		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
