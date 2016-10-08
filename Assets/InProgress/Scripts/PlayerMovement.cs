using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;
}

public class PlayerMovement : MonoBehaviour {
	public int playerNumber;
	public float speed;

	private Transform playerTransform;

	private string horizontalAxis;
	private string verticalAxis;

	// Use this for initialization
	void Start () {
		playerTransform = GetComponent<Transform> ();

		horizontalAxis = "Player " + playerNumber + " Horizontal";
		verticalAxis = "Player " + playerNumber + " Vertical";
	}
	public Boundary boundary;


	void FixedUpdate ()
	{
		
		if (Input.GetAxis(horizontalAxis) > 0) {
			playerTransform.Translate (speed * Vector3.right * Time.deltaTime);
			CheckBoundaries ();
		}
		if (Input.GetAxis (horizontalAxis) < 0) {
			playerTransform.Translate (speed * Vector3.left * Time.deltaTime);
			CheckBoundaries();
		}
		if (Input.GetAxis(verticalAxis) > 0) {
			playerTransform.Translate (speed * Vector3.up * Time.deltaTime);
			CheckBoundaries ();
		}
		if (Input.GetAxis(verticalAxis) < 0) {
			playerTransform.Translate (speed * Vector3.down * Time.deltaTime);
			CheckBoundaries ();
		}
	}

	void CheckBoundaries ()
	{
		Vector3 clampedPosition = transform.position;
		clampedPosition.x = Mathf.Clamp (playerTransform.position.x, boundary.xMin, boundary.xMax);
		clampedPosition.y = Mathf.Clamp (playerTransform.position.y, boundary.yMin, boundary.yMax);
		transform.position = clampedPosition;
	}
}
