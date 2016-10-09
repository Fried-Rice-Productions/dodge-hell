using UnityEngine;
using System.Collections;

public class PlayerShot : MonoBehaviour {

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;

	private Transform playerTransform;

	private float nextFire;
	private string fireButtonName;

	// Use this for initialization
	void Start () {
		playerTransform = GetComponentInParent<Transform>();
		fireButtonName = playerTransform.name + " Fire";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton (fireButtonName) && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		}
	}
}
