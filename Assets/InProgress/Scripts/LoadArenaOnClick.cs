using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadArenaOnClick : MonoBehaviour {
	
	public void loadScene() {
		SceneManager.LoadScene ("Arena");
	}
}
