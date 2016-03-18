using UnityEngine;
using System.Collections;
using Image = UnityEngine.UI.Image;

public class Dialogue6 : MonoBehaviour {

	public GameObject panel;
	public GameObject panel1;
	public GameObject text1;
	public GameObject text2;
	public GameObject text3;
	public GameObject text4;
	public GameObject text5;

	void Start () {
		panel.SetActive (false);
		panel1.GetComponent<Image> ().CrossFadeAlpha (0F, 0F, false);
		text1.SetActive (false);
		text2.SetActive (false);
		text3.SetActive (false);
		text4.SetActive (false);
		text5.SetActive (false);
	}

	void Update() {
		if (Time.timeSinceLevelLoad >= 40) {
			panel1.GetComponent<Image> ().CrossFadeAlpha (1F, 2.5F, false);
		} else if (Time.timeSinceLevelLoad >= 30) {
			text5.SetActive (false);
			panel.SetActive (false);
		} else if (Time.timeSinceLevelLoad >= 28) {
			text4.SetActive (false);
			text5.SetActive (true);
		} else if (Time.timeSinceLevelLoad >= 23) {
			text3.SetActive (false);
			text4.SetActive (true);
		} else if (Time.timeSinceLevelLoad >= 18) {
			text2.SetActive (false);
			text3.SetActive (true);
		} else if (Time.timeSinceLevelLoad >= 15) {
			text1.SetActive (false);
			text2.SetActive (true);
		} else if (Time.timeSinceLevelLoad >= 12) {
			panel.SetActive (true);
			text1.SetActive (true);
		}
	}
}
