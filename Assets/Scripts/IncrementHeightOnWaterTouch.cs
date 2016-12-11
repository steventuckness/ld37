using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

public class IncrementHeightOnWaterTouch : MonoBehaviour {

    public string[] collisionTags;
    public float sizeIncrement;

	// Use this for initialization
	void Start () {
        		
	}
	
	// Update is called once per frame
	void Update () {
	    	
	}

    private void OnParticleCollision(GameObject other)
    {
            gameObject.transform.Translate(new Vector3(0, sizeIncrement, 0));
    }
}
