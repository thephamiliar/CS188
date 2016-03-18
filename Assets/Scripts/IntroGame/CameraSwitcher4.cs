using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CameraSwitcher4 : MonoBehaviour {

	public Camera camera1;
	private int currentCamera;

	void Start () {
		currentCamera = 1;
		camera1.enabled = true;
	}

	void Update() {
		if (Time.timeSinceLevelLoad >= 20) {
			SceneManager.LoadScene (4);
		} else if (Time.timeSinceLevelLoad  >= 16) {
			gameObject.GetComponent<FadingScene> ().BeginFade (1);
		}
	}

	void LateUpdate() {
		switch (currentCamera) {
		case 1:
			if (Time.timeSinceLevelLoad  > 5 & Time.timeSinceLevelLoad  < 15) {
				camera1.transform.Translate (Vector3.forward * Time.deltaTime/3);
			}
			break;
		default:
			break;
		}
	}
}
