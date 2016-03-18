using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CameraSwitcher2 : MonoBehaviour {
	
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
		if (Time.timeSinceLevelLoad >= 110) {
			SceneManager.LoadScene (2);
		} else if (Time.timeSinceLevelLoad  >= 109) {
			gameObject.GetComponent<FadingScene> ().BeginFade (2);
		} else if (Time.timeSinceLevelLoad  >= 90) {
			camera2.enabled = false;
			camera4.enabled = true;
			currentCamera = 4;
		} else if (Time.timeSinceLevelLoad  >= 80) {
			camera6.enabled = false;
			camera2.enabled = true;
			currentCamera = 2;
		} else if (Time.timeSinceLevelLoad  >= 70) {
			camera5.enabled = false;
			camera6.enabled = true;
			currentCamera = 6;
		} else if (Time.timeSinceLevelLoad  >= 65) {
			camera6.enabled = false;
			camera5.enabled = true;
			currentCamera = 5;
		} else if (Time.timeSinceLevelLoad  >= 60) {
			camera5.enabled = false;
			camera6.enabled = true;
			currentCamera = 6;
		} else if (Time.timeSinceLevelLoad  >= 57) {
			camera4.enabled = false;
			camera5.enabled = true;
			currentCamera = 5;
		} else if (Time.timeSinceLevelLoad  >= 52) {
			camera3.enabled = false;
			camera4.enabled = true;
			currentCamera = 4;
		} else if (Time.timeSinceLevelLoad  >= 45) {
			camera2.enabled = false;
			camera3.enabled = true;
			currentCamera = 3;
		} else if (Time.timeSinceLevelLoad  >= 25) {
			camera1.enabled = false;
			camera2.enabled = true;
			currentCamera = 2;
		}
	}

	void LateUpdate() {
		switch (currentCamera) {
		case 1:
			if (Time.timeSinceLevelLoad  > 0 & Time.timeSinceLevelLoad  < 20) {
				camera1.transform.Rotate (0, Time.deltaTime * 2, 0);
				camera1.transform.Translate (-Time.deltaTime/4, 0, 0);
			}
			break;
		case 2:
			if (Time.timeSinceLevelLoad  > 30 & Time.timeSinceLevelLoad  < 40) {
				camera2.transform.Translate (Time.deltaTime/2 * -1, 0, 0);
			}
			if (Time.timeSinceLevelLoad  > 80) {
				camera2.transform.Translate (Vector3.forward * Time.deltaTime/4);
			}
			break;
		case 3:
			if (Time.timeSinceLevelLoad  > 45 & Time.timeSinceLevelLoad  < 50) {
				camera3.transform.Translate (Vector3.forward * Time.deltaTime);
			}
			break;
		case 4:
			if (Time.timeSinceLevelLoad  > 100 && Time.timeSinceLevelLoad  < 105) {
				camera4.transform.Translate (Vector3.forward * Time.deltaTime/2);
			}
			break;
		default:
			break;
		}
	}
}
