using UnityEngine;
using System.Collections;

public class ClearPlayer2 : MonoBehaviour {

	//private string ClearButtonName;

	void Update ()
	{

		//		if (Input.GetButton (ClearButtonName) {
		if (Input.GetKeyDown (KeyCode.RightShift)) {
			DestroyAllObjects ();
		}
	}

	void DestroyAllObjects()
	{
		GameObject[] Player1Shot;

		Player1Shot = GameObject.FindGameObjectsWithTag ("Player1Shot");

		for(var i = 0 ; i < Player1Shot.Length ; i ++)
		{
			Destroy(Player1Shot[i]);
		}
	}
}
