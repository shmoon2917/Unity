using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour {

	public Vector3 vec3;

	// Use this for initialization
	void Start () {


//		gameObject.transform.Translate(new Vector3(4.0f,4.0f,4.0f));
	}
	
	// Update is called once per frame
	void Update () {

		gameObject.transform.Rotate (vec3);
		gameObject.transform.localScale = gameObject.transform.localScale + vec3;
		gameObject.transform.Translate(vec3);

	}
}
