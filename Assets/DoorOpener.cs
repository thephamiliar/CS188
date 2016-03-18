using UnityEngine;
using System.Collections;

public class DoorOpener : MonoBehaviour {
	public GameObject doorObject;
	public bool openedDoor;
	// Use this for initialization
	void Start () {
		openedDoor = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider obj) {
		if (openedDoor){
			doorObject.GetComponent<Animation>().Play();
			openedDoor = false;
		}
	}
}
