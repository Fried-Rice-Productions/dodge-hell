using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary2
{
	public float xMin, xMax, yMin, yMax;
}

public class Player2Movement : MonoBehaviour {
	public float speed;

	private Transform transform;
	// Use this for initialization
	void Start () {
		transform = GetComponent<Transform> ();
	}
	public Boundary2 boundary;
	// Update is called once per frame
	void FixedUpdate ()
	{
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (speed * Vector3.right * Time.deltaTime);
			Vector3 clampedPosition = transform.position;
			clampedPosition.x = Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax);
			clampedPosition.y = Mathf.Clamp(transform.position.y, boundary.yMin, boundary.yMax);
			transform.position = clampedPosition;
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (speed * Vector3.left * Time.deltaTime);
			Vector3 clampedPosition = transform.position;
			clampedPosition.x = Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax);
			clampedPosition.y = Mathf.Clamp(transform.position.y, boundary.yMin, boundary.yMax);
			transform.position = clampedPosition;
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (speed * Vector3.up * Time.deltaTime);
			Vector3 clampedPosition = transform.position;
			clampedPosition.x = Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax);
			clampedPosition.y = Mathf.Clamp(transform.position.y, boundary.yMin, boundary.yMax);
			transform.position = clampedPosition;
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (speed * Vector3.down * Time.deltaTime);
			Vector3 clampedPosition = transform.position;
			clampedPosition.x = Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax);
			clampedPosition.y = Mathf.Clamp(transform.position.y, boundary.yMin, boundary.yMax);
			transform.position = clampedPosition;
		}

	}
}

