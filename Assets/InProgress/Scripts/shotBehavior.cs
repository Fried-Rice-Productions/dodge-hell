using UnityEngine;
using System.Collections;

public class shotBehavior : MonoBehaviour {
	
	public float speed;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		//gave it some SPEED
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
