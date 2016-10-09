using UnityEngine;
using System.Collections;

public class PauseOnClick : MonoBehaviour {

	public bool isPaused = false;
	public GameObject pauseCanvas;
	public UnityEngine.UI.Button resumeButton;

	// Use this for initialization
	void Start () {
		//pauseCanvas = GameObject.FindWithTag ("Pause");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			isPaused = !isPaused;
			handleIsPaused ();
		}
			
	}

	public void handleIsPaused ()
	{
		if (isPaused) {
			pauseCanvas.SetActive (true);
			resumeButton.Select ();
			Time.timeScale = 0;
		}
		else {
			pauseCanvas.SetActive (false);
			Time.timeScale = 1;
		}
	}

}
