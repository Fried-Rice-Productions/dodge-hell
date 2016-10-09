using UnityEngine;
using System.Collections;

public class ResumeOnClick : MonoBehaviour {

	public PauseOnClick pauseOnClick;

	public void resume() {
		pauseOnClick.isPaused = false;
		pauseOnClick.handleIsPaused ();
	}
}
