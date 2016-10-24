using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {
	//public GameObject explosion;
	public GameObject explosion;

	// Use this for initialization
	void Start () {

	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Boundary") || other.CompareTag("Player1Shot") ) {
			return;
		}
		Instantiate (explosion, transform.position, transform.rotation);
		Destroy (other.gameObject);
		Destroy (gameObject);


	}



	// Update is called once per frame
	void Update () {

	}
}
