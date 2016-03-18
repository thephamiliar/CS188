using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CameraSwitcher3 : MonoBehaviour {

	public Camera camera1;
	public Camera camera2;
	public Camera camera3;
	public Camera camera4;
	public Camera camera5;
	public Camera camera6;

	private int currentCamera;

	void Start () {
		currentCamera = 1;
		camera1.enabled = true;
		camera2.enabled = false;
		camera3.enabled = false;
		camera4.enabled = false;
		camera5.enabled = false;
		camera6.enabled = false;
	}

	void Update() {
		if (Time.timeSinceLevelLoad >= 93) {
			SceneManager.LoadScene (3);
		} else if (Time.timeSinceLevelLoad  >= 92) {
			gameObject.GetComponent<FadingScene> ().BeginFade (3);
		} else if (Time.timeSinceLevelLoad  >= 75) {
			camera5.enabled = false;
			camera6.enabled = true;
			currentCamera = 6;
		} else if (Time.timeSinceLevelLoad  >= 72) {
			camera4.enabled = false;
			camera5.enabled = true;
			currentCamera = 5;
		} else if (Time.timeSinceLevelLoad  >= 65) {
			camera3.enabled = false;
			camera4.enabled = true;
			currentCamera = 4;
		} else if (Time.timeSinceLevelLoad  >= 57) {
			camera1.enabled = false;
			camera3.enabled = true;
			currentCamera = 3;
		} else if (Time.timeSinceLevelLoad  >= 42) {
			camera2.enabled = false;
			camera1.enabled = true;
			currentCamera = 1;
		} else if (Time.timeSinceLevelLoad  >= 12) {
			camera1.enabled = false;
			camera2.enabled = true;
			currentCamera = 2;
		}
	}

	void LateUpdate() {
		switch (currentCamera) {
		case 1:
			if (Time.timeSinceLevelLoad  > 4 & Time.timeSinceLevelLoad  < 8) {
				camera1.transform.Translate (Vector3.back * Time.deltaTime/3);
			}
			if (Time.timeSinceLevelLoad  > 45 & Time.timeSinceLevelLoad  < 52) {
				camera1.transform.Rotate (0, Time.deltaTime * -2, 0);
			}
			break;
		case 2:
			if (Time.timeSinceLevelLoad  > 12 & Time.timeSinceLevelLoad  < 37) {
				camera2.transform.Rotate (0, Time.deltaTime * -3, 0);
				camera2.transform.Translate (Vector3.right * Time.deltaTime/3);
			}
			break;
		case 3:
			if (Time.timeSinceLevelLoad  > 57 & Time.timeSinceLevelLoad  < 67) {
				camera3.transform.Translate (Vector3.left * Time.deltaTime/2);
			}
			break;
		case 4:
			if (Time.timeSinceLevelLoad  > 67 && Time.timeSinceLevelLoad  < 72) {
				camera4.transform.Rotate (0, Time.deltaTime * -2, 0);
				camera4.transform.Translate (Vector3.left * Time.deltaTime/4);
			}
			break;
		case 6:
			if (Time.timeSinceLevelLoad >= 82 && Time.timeSinceLevelLoad  <= 87) {
				camera6.transform.Translate (Vector3.forward * Time.deltaTime/2);
			}
			break;
		default:
			break;
		}
	}
}
