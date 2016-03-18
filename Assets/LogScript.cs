using UnityEngine;
using System.Collections;

public class LogScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad  > 32 & Time.timeSinceLevelLoad  < 39) {
			transform.Translate (Time.deltaTime/2, 0, 0);
		}
		if (Time.timeSinceLevelLoad  >= 80) {
			gameObject.SetActive (false);
		}
	}
}
