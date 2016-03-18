using UnityEngine;
using System.Collections;

public class Dialogue5 : MonoBehaviour {

	public GameObject panel;
	public GameObject text1;
	public GameObject text2;
	public GameObject text3;
	public GameObject text4;
	public GameObject text5;

	void Start () {
		panel.SetActive (false);
		text1.SetActive (false);
		text2.SetActive (false);
		text3.SetActive (false);
		text4.SetActive (false);
		text5.SetActive (false);
	}

	void Update() {
		if (Time.timeSinceLevelLoad  >= 30) {
			gameObject.SetActive (false);
		} else if (Time.timeSinceLevelLoad  >= 25) {
			text4.SetActive (false);
			text5.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 20) {
			text3.SetActive (false);
			text4.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 15) {
			text2.SetActive (false);
			text3.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 11) {
			text1.SetActive (false);
			text2.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 7) {
			panel.SetActive (true);
			text1.SetActive (true);
		}
	}
}
