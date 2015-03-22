using UnityEngine;
using System.Collections;

public class pushTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		rigidbody.AddForce (transform.forward * 5000);
		rigidbody.useGravity = true;
	}
}
