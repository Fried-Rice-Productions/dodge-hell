using UnityEngine;
using System.Collections;

public class Player2Shot : MonoBehaviour {
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	public GameObject Shot;
	public Transform shotSpawn;
	public float fireRate;
	private float nextFire;

	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Player 2 Fire") && Time.time > nextFire) {
			//fire rate
			nextFire = Time.time + fireRate;
			Instantiate (Shot, shotSpawn.position, shotSpawn.rotation);

		}
	}
}
