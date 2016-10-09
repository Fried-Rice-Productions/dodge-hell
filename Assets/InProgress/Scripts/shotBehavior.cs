using UnityEngine;
using System.Collections;

public class shotBehavior : MonoBehaviour {
	
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//get shot current pos
		Vector2 pos = transform.position;
		 //compute new pos
		pos = new Vector2(pos.x + speed * Time.deltaTime , pos.y);
		//update current pos
		transform.position = pos;

		//destroy when leaves background

	}
}
