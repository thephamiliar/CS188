using UnityEngine;
using System.Collections;

public class CameraSwitcher5 : MonoBehaviour {

	public Camera camera1;
	public Camera camera2;
	public Camera camera3;
	public Camera camera4;
	private int currentCamera;

	void Start () {
		currentCamera = 1;
		camera1.enabled = true;
		camera2.enabled = false;
		camera3.enabled = false;
		camera4.enabled = false;
	}

	void Update() {
		if (Time.timeSinceLevelLoad >= 28) {
			camera3.enabled = false;
			camera4.enabled = true;
			currentCamera = 4;
		} else if (Time.timeSinceLevelLoad >= 18) {
			camera2.enabled = false;
			camera3.enabled = true;
			currentCamera = 3;
		} else if (Time.timeSinceLevelLoad >= 12) {
			camera1.enabled = false;
			camera2.enabled = true;
			currentCamera = 2;
		}
	}

	void LateUpdate() {
		switch (currentCamera) {
		case 1:
			if (Time.timeSinceLevelLoad > 7 & Time.timeSinceLevelLoad < 10) {
				camera1.transform.Translate (Vector3.up * Time.deltaTime/5);
			}
			break;
		case 4:
			if (Time.timeSinceLevelLoad > 30 & Time.timeSinceLevelLoad < 35) {
				camera4.transform.Translate (Vector3.forward * Time.deltaTime / 3);
			}
			break;
		}
	}
}
