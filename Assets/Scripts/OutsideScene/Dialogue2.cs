using UnityEngine;
using System.Collections;

public class Dialogue2 : MonoBehaviour {

	public GameObject panel;
	public GameObject text1;
	public GameObject text2;
	public GameObject text3;
	public GameObject text4;
	public GameObject text5;
	public GameObject text6;
	public GameObject text7;
	public GameObject text8;
	public GameObject text9;

	void Start () {
		panel.SetActive (false);
		text1.SetActive (false);
		text2.SetActive (false);
		text3.SetActive (false);
		text4.SetActive (false);
		text5.SetActive (false);
		text6.SetActive (false);
		text7.SetActive (false);
		text8.SetActive (false);
		text9.SetActive (false);
	}

	void Update() {
		if (Time.timeSinceLevelLoad  >= 95) {
			gameObject.SetActive (false);
		} else if (Time.timeSinceLevelLoad  >= 92) {
			panel.SetActive (true);
			text9.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 85) {
			panel.SetActive (false);
			text8.SetActive (false);
		} else if (Time.timeSinceLevelLoad  >= 82) {
			panel.SetActive (true);
			text8.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 80) {
			panel.SetActive (false);
			text7.SetActive (false);
		} else if (Time.timeSinceLevelLoad  >= 75) {
			text6.SetActive (false);
			text7.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 70) {
			text5.SetActive (false);
			text6.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 65) {
			text4.SetActive (false);
			text5.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 62) {
			text3.SetActive (false);
			text4.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 60) {
			text2.SetActive (false);
			text3.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 57) {
			panel.SetActive (true);
			text2.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 40) {
			panel.SetActive (false);
			text1.SetActive (false);
		} else if (Time.timeSinceLevelLoad  >= 36) {
			panel.SetActive (true);
			text1.SetActive (true);
		}
	}
}
