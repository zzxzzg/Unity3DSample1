using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary{
	public float mMaxX;
	public float mMinX;
	public float mMaxZ;
	public float mMinZ;
}

public class PlayController : MonoBehaviour {
	public float speed = 5.0f;
	public Boundary mBoundary;
	public float tile = 4;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	// 每隔固定的时间间隔被调用
	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal,0f,moveVertical);

		Rigidbody rigidbody = GetComponent<Rigidbody> ();
		if (rigidbody != null) {
			rigidbody.velocity = movement * speed;
			rigidbody.position = new Vector3 (Mathf.Clamp(rigidbody.position.x,mBoundary.mMinX,mBoundary.mMaxX)
			,0.0f,Mathf.Clamp(rigidbody.position.z,mBoundary.mMinZ,mBoundary.mMaxZ)
			);
			rigidbody.rotation = Quaternion.Euler (new Vector3 (0.0f, 0.0f, rigidbody.velocity.x * -tile));
		}
	}
}
