using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CameraSwitcher1 : MonoBehaviour {

	public Camera camera1;
	public Camera camera2;
	public Camera camera3;
	public Camera camera4;
	public Camera camera5;

	private int currentCamera;

	void Start () {
		currentCamera = 1;
		camera1.enabled = true;
		camera2.enabled = false;
		camera3.enabled = false;
		camera4.enabled = false;
		camera5.enabled = false;
		AudioSource audio = camera1.GetComponent<AudioSource>();
		audio.PlayDelayed (3.0F);
	}

	void Update() {
		if (Time.timeSinceLevelLoad >= 60) {
			SceneManager.LoadScene (1);
		} else if (Time.timeSinceLevelLoad  >= 59) {
			gameObject.GetComponent<FadingScene> ().BeginFade (1);
		} else if (Time.timeSinceLevelLoad  >= 53) {
			camera4.enabled = false;
			camera5.enabled = true;
			currentCamera = 5;
		} else if (Time.timeSinceLevelLoad  >= 35) {
			camera3.enabled = false;
			camera4.enabled = true;
			currentCamera = 4;
		} else if (Time.timeSinceLevelLoad  >= 30) {
			camera2.enabled = false;
			camera3.enabled = true;
			currentCamera = 3;
		} else if (Time.timeSinceLevelLoad  >= 20) {
			camera1.enabled = false;
			camera2.enabled = true;
			currentCamera = 2;
		}
	}

	void LateUpdate() {
		switch (currentCamera) {
		case 1:
			if (Time.timeSinceLevelLoad  > 5 & Time.timeSinceLevelLoad  < 15) {
				camera1.transform.Translate (Vector3.back * Time.deltaTime/3);
			}
			break;
		case 2:
			if (Time.timeSinceLevelLoad  > 20 & Time.timeSinceLevelLoad  < 25) {
				camera2.transform.Rotate (0, 3 * Time.deltaTime, 0);
			}
			break;
		default:
			break;
		}
	}
}
