using UnityEngine;
using System.Collections;

public class CameraSwitcher : MonoBehaviour {

	public Camera camera1;
	public Camera camera2;
	public Camera camera3;
	public Camera camera4;
	public Camera camera5;
	public Camera camera6;
	public GameObject player;
	private int currentCamera;
	[SerializeField]
	private float distanceAway;
	[SerializeField]
	private float distanceUp;
	[SerializeField]
	private float smooth;
	private Transform follow;
	private Vector3 targetPosition;
	private bool playerMode;

	void Start () {
		currentCamera = 1;
		playerMode = false;

		camera1.enabled = true;
		camera2.enabled = false;
		camera3.enabled = false;
		camera4.enabled = false;
		camera5.enabled = false;
		camera6.enabled = false;

		follow = player.transform;
	}

	void Update() {
		if (Time.timeSinceLevelLoad  >= 50) {
			camera5.enabled = false;
			camera6.enabled = true;
			currentCamera = 6;
			playerMode = true;
		} else if (Time.timeSinceLevelLoad  >= 45) {
			camera6.enabled = false;
			camera5.enabled = true;
			currentCamera = 5;
		} else if (Time.timeSinceLevelLoad  >= 40) {
			camera5.enabled = false;
			camera6.enabled = true;
			currentCamera = 6;
		} else if (Time.timeSinceLevelLoad  >= 35) {
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
		} else if (Time.timeSinceLevelLoad  >= 15) {
			camera1.enabled = false;
			camera2.enabled = true;
			currentCamera = 2;
		}
	}

	void LateUpdate() {
		switch (currentCamera) {
		case 1:
			if (Time.timeSinceLevelLoad  >= 3 && Time.timeSinceLevelLoad  <= 13) {
				camera1.transform.Translate (Vector3.forward * Time.deltaTime / 2);
			}
			break;
		case 2:
			if (Time.timeSinceLevelLoad  >= 17 && Time.timeSinceLevelLoad  <= 23) {
				camera2.transform.Rotate (0, Time.deltaTime * -4, 0);
				camera2.transform.Translate (Vector3.right * Time.deltaTime / 2);
			}
			break;
		case 6:
			if (playerMode) {
				targetPosition = follow.position + Vector3.up * distanceUp - follow.forward * distanceAway;
				camera6.transform.position = Vector3.Lerp (camera6.transform.position, targetPosition, Time.deltaTime * smooth);
				camera6.transform.LookAt (follow);
			}
			break;
		default:
			break;
		}
	}
}
