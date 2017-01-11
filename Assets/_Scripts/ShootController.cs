using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour {
	public float fireRate =0.5f;

	public GameObject bolt;

	public Transform shootPos;

	private float nextFire =0.0f;
	// Use this for initialization
	void Start () {
		shootPos = transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1") && Time.time > nextFire) {
			Instantiate (bolt, shootPos.position, shootPos.rotation);
			nextFire = Time.time + fireRate;
		}
	}
}
