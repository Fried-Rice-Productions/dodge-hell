using UnityEngine;
using System.Collections;

public class Player2Movement : MonoBehaviour {
	public float speed;

	private Transform transform;
	// Use this for initialization
	void Start () {
		transform = GetComponent<Transform> ();
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (speed * Vector3.right * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (speed * Vector3.left * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (speed * Vector3.up * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (speed * Vector3.down * Time.deltaTime);
		}

	}
}

