using UnityEngine;
using System.Collections;

public class ClearPlayer1 : MonoBehaviour {
	
	//private string ClearButtonName;

	void Update ()
	{

//		if (Input.GetButton (ClearButtonName) {
		if (Input.GetKeyDown (KeyCode.E)) {
			DestroyAllObjects ();
		}
	}

	void DestroyAllObjects()
	{
		GameObject[] Player2Shot;

		Player2Shot = GameObject.FindGameObjectsWithTag ("Player2Shot");

		for(var i = 0 ; i < Player2Shot.Length ; i ++)
		{
			Destroy(Player2Shot[i]);
		}
	}
}
