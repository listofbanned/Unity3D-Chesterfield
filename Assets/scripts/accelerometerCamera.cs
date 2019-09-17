using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class accelerometerCamera : MonoBehaviour {
	private float timer;
	void Update() {
		if (end.TouchWin == false) {
			transform.Translate (0,0,0.25f);
		}
		if (end.TouchWin == true) {
			timer = timer - 1*Time.deltaTime;
			transform.Rotate (0 + timer,0,0);
			if (timer < -1.499f) {
				SceneManager.LoadScene ("2-final");
			}
		}
	}
}