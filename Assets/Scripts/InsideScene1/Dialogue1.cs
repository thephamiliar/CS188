using UnityEngine;
using System.Collections;
using Image = UnityEngine.UI.Image;

public class Dialogue1 : MonoBehaviour {

	public GameObject panel;
	public GameObject panel1;
	public GameObject text1;
	public GameObject text2;
	public GameObject text3;
	public GameObject text4;
	public GameObject text5;
	public GameObject text6;

	void Start () {
		panel.SetActive (false);
		text1.SetActive (false);
		text2.SetActive (false);
		text3.SetActive (false);
		text4.SetActive (false);
		text5.SetActive (false);
		text6.SetActive (false);
	}

	void Update() {
		if (Time.timeSinceLevelLoad  >= 53) {
			gameObject.SetActive (false);
		} else if (Time.timeSinceLevelLoad  >= 48) {
			text5.SetActive (false);
			text6.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 45) {
			text4.SetActive (false);
			text5.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 42) {
			text3.SetActive (false);
			text4.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 40) {
			text2.SetActive (false);
			text3.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 37) {
			text1.SetActive (false);
			text2.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 35) {
			panel.SetActive (true);
			text1.SetActive (true);
		} else if (Time.timeSinceLevelLoad >= 5) {
			panel1.GetComponent<Image> ().CrossFadeAlpha (0F, 2.5F, false);
		}
	}
}
