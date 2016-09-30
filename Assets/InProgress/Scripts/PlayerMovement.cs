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

	void Update
	{
		Instantiate 
	}
	// Update is called once per frame
	void FixedUpdate ()
	{
		
	/*	rb.position = new Vector3 (
			Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax),
			Mathf.Clamp (rb.position.y, boundary.xMin, boundary.xMax)
		);*/
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (speed * Vector3.right * Time.deltaTime);
			Vector3 clampedPosition = transform.position;
			clampedPosition.x = Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax);
			clampedPosition.y = Mathf.Clamp(transform.position.y, boundary.yMin, boundary.yMax);
			transform.position = clampedPosition;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (speed * Vector3.left * Time.deltaTime);
			Vector3 clampedPosition = transform.position;
			clampedPosition.x = Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax);
			clampedPosition.y = Mathf.Clamp(transform.position.y, boundary.yMin, boundary.yMax);
			transform.position = clampedPosition;
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (speed * Vector3.up * Time.deltaTime);
			Vector3 clampedPosition = transform.position;
			clampedPosition.x = Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax);
			clampedPosition.y = Mathf.Clamp(transform.position.y, boundary.yMin, boundary.yMax);
			transform.position = clampedPosition;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (speed * Vector3.down * Time.deltaTime);
			Vector3 clampedPosition = transform.position;
			clampedPosition.x = Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax);
			clampedPosition.y = Mathf.Clamp(transform.position.y, boundary.yMin, boundary.yMax);
			transform.position = clampedPosition;
		}
				//bounce back result of movement method conflicting with boxcollider boundaries
	}

}
