﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour {

	void OnMouseDrag() {
		float distance_to_screen = Camera.main.WorldToScreenPoint (gameObject.transform.position).z;
		transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 
			Input.mousePosition.y, distance_to_screen));
	}
}