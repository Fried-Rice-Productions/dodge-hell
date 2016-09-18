using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;
}

public class PlayerMovement : MonoBehaviour {
	public float speed;

	private Transform transform;
	private Rigidbody2D rb;


	// Use this for initialization
	void Start () {
		transform = GetComponent<Transform> ();
		rb = GetComponent<Rigidbody2D> ();
	}
	public Boundary boundary;
	// Update is called once per frame
	void FixedUpdate ()
	{
	/*	rb.position = new Vector3 (
			Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax),
			Mathf.Clamp (rb.position.y, boundary.yMin, boundary.yMax)
		);*/
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (speed * Vector3.right * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (speed * Vector3.left * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (speed * Vector3.up * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (speed * Vector3.down * Time.deltaTime);
		}
				//bounce back result of movement method conflicting with boxcollider boundaries
	}

}
