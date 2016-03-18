using UnityEngine;
using System.Collections;

public class Dialogue4 : MonoBehaviour {

	public GameObject panel;
	public GameObject text1;
	public GameObject text2;
	public GameObject text3;
	public GameObject text4;

	void Start () {
		panel.SetActive (false);
		text1.SetActive (false);
		text2.SetActive (false);
		text3.SetActive (false);
		text4.SetActive (false);
	}

	void Update() {
		if (Time.timeSinceLevelLoad  >= 50) {
			gameObject.SetActive (false);
		} else if (Time.timeSinceLevelLoad  >= 47) {
			text3.SetActive (false);
			text4.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 45) {
			text2.SetActive (false);
			text3.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 40) {
			text1.SetActive (false);
			text2.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 35) {
			panel.SetActive (true);
			text1.SetActive (true);
		}
	}
}
