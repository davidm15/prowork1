using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demo : MonoBehaviour {

	public float x;
	public float y;
	public float z;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Vector3 go = new Vector3 (x, y, z);

		transform.Rotate (go);
	}
}
