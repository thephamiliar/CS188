using UnityEngine;
using System.Collections;

public class ChildEndingBehavior : MonoBehaviour {
	enum State {
		IDLE = 0,
		CAREFULWALK = 1,
		SHYWALK = 2,
		RUNJOG = 3,
		RUNFORWARD = 4,
		HAPPY = 5,
		SADWALK = 6,
		SCAREDWALK = 7,
		TALK = 8,
		SLEEP = 9
	}

	public GameObject spiral;
	private Animator animator;
	private State currentState;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		currentState = State.IDLE;
		spiral.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad >= 45) {
			spiral.SetActive (false);
		} else if (Time.timeSinceLevelLoad >= 37) {
			spiral.SetActive (true);
		} else if (Time.timeSinceLevelLoad >= 28) {
			animator.SetFloat ("Speed", 0.7F);
			AnimationChange (State.RUNJOG);
		} else if (Time.timeSinceLevelLoad >= 12) {
			AnimationChange (State.IDLE);
		} else if (Time.timeSinceLevelLoad >= 5) {
			animator.SetTrigger ("WakeUp");
		} else if (Time.timeSinceLevelLoad >= 0) {
			AnimationChange (State.SLEEP);
		}
	}

	void AnimationChange(State newState) {
		if (newState != currentState) {
			currentState = newState;
			switch (currentState) {
			case State.IDLE:
				transform.localPosition = new Vector3 (0.01F, 1.16F, -10.52F);
				break;
			case State.RUNJOG:
				transform.Rotate (0, 90, 0);
				break;
			}
			animator.SetInteger ("State", (int)newState);
		}
	}
}
