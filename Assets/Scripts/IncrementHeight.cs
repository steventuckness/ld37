using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementHeight : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (new Vector3 (0, speed * Time.deltaTime, 0));
	}
}
