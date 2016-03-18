using UnityEngine;
using System.Collections;

public class Dialogue3 : MonoBehaviour {

	public GameObject panel;
	public GameObject text1;
	public GameObject text2;
	public GameObject text3;
	public GameObject text4;
	public GameObject text5;
	public GameObject text6;
	public GameObject text7;

	void Start () {
		panel.SetActive (false);
		text1.SetActive (false);
		text2.SetActive (false);
		text3.SetActive (false);
		text4.SetActive (false);
		text5.SetActive (false);
		text6.SetActive (false);
		text7.SetActive (false);
	}

	void Update() {
		if (Time.timeSinceLevelLoad  >= 65) {
			gameObject.SetActive (false);
		} else if (Time.timeSinceLevelLoad  >= 61) {
			panel.SetActive (true);
			text7.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 57) {
			panel.SetActive (false);
			text6.SetActive (false);
		} else if (Time.timeSinceLevelLoad  >= 52) {
			text5.SetActive (false);
			text6.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 45) {
			panel.SetActive (true);
			text5.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 40) {
			panel.SetActive (false);
			text4.SetActive (false);
		} else if (Time.timeSinceLevelLoad  >= 34) {
			text3.SetActive (false);
			text4.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 26) {
			text2.SetActive (false);
			text3.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 22) {
			text1.SetActive (false);
			text2.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 14) {
			panel.SetActive (true);
			text1.SetActive (true);
		}
	}
}
