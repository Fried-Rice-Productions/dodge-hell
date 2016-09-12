using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed;

	private Transform transform;
	// Use this for initialization
	void Start () {
		transform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.RightArrow)) {
			Debug.Log ("patrick is a weiner a poopy weiner");
			transform.Translate (speed * Vector3.right * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			Debug.Log ("patrick is a weiner a poopy weiner");
			transform.Translate (speed * Vector3.left * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			Debug.Log ("patrick is a weiner a poopy weiner");
			transform.Translate (speed * Vector3.up * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			Debug.Log ("patrick is a weiner a poopy weiner");
			transform.Translate (speed * Vector3.down * Time.deltaTime);
		}
		
	}
}
