using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CameraSwitcher6 : MonoBehaviour {

	public Camera camera1;
	public Camera camera2;
	public Camera camera3;
	public Camera camera4;
	public Camera camera5;

	private int currentCamera;
	private int speed;

	void Start () {
		currentCamera = 1;
		speed = 1;
		camera1.enabled = true;
		camera2.enabled = false;
		camera3.enabled = false;
		camera4.enabled = false;
		camera5.enabled = false;
	}

	void Update() {
		if (Time.timeSinceLevelLoad >= 40) {
			SceneManager.LoadScene (6);
		} else if (Time.timeSinceLevelLoad  >= 39) {
			gameObject.GetComponent<FadingScene> ().BeginFade (1);
		} else if (Time.timeSinceLevelLoad  >= 37) {
			camera4.enabled = false;
			camera5.enabled = true;
			currentCamera = 5;
		} else if (Time.timeSinceLevelLoad  >= 30) {
			camera3.enabled = false;
			camera4.enabled = true;
			currentCamera = 4;
		} else if (Time.timeSinceLevelLoad  >= 25) {
			camera2.enabled = false;
			camera3.enabled = true;
			currentCamera = 3;
		} else if (Time.timeSinceLevelLoad  >= 20) {
			camera3.enabled = false;
			camera2.enabled = true;
			currentCamera = 2;
		} else if (Time.timeSinceLevelLoad  >= 15) {
			camera2.enabled = false;
			camera3.enabled = true;
			currentCamera = 3;
		} else if (Time.timeSinceLevelLoad  >= 7) {
			camera1.enabled = false;
			camera2.enabled = true;
			currentCamera = 2;
		}
	}

	void LateUpdate() {
		switch (currentCamera) {
		case 1:
			if (Time.timeSinceLevelLoad  > 0 & Time.timeSinceLevelLoad  < 5) {
				camera1.transform.Translate (Vector3.forward * Time.deltaTime);
			}
			break;
		case 4:
			if (Time.timeSinceLevelLoad  > 30 && Time.timeSinceLevelLoad  < 37) {
				camera4.transform.RotateAround(GameObject.FindWithTag("Player").transform.position, Vector3.up, Time.deltaTime*speed);
				speed += 2;
			}
			break;
		default:
			break;
		}
	}
}
