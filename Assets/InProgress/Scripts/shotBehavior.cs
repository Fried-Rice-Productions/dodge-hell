﻿using UnityEngine;
using System.Collections;

public class shotBehavior : MonoBehaviour {
	
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(speed * Vector3.right * Time.deltaTime);
	}
}
