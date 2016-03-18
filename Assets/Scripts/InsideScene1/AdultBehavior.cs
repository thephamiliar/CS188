using UnityEngine;
using System.Collections;

public class AdultBehavior : MonoBehaviour {
	enum State {
		IDLE = 0,
		SIT = 1,
		STERNWALK = 2,
		ANGRY = 3,
		TALK = 4,
		LEANDOWN = 5,
		SLEEP = 6
	}

	private Animator animator;
	private State currentState;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		currentState = State.IDLE;
	}

	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad  >= 50) {
			AnimationChange (State.IDLE);
		} else if (Time.timeSinceLevelLoad  >= 35) {
			AnimationChange (State.ANGRY);
		} else if (Time.timeSinceLevelLoad  >= 32) {
			AnimationChange (State.IDLE);
		} else if (Time.timeSinceLevelLoad  >= 30) {
			AnimationChange (State.STERNWALK);
		} else if (Time.timeSinceLevelLoad  >= 20) {
			AnimationChange (State.IDLE);
		} else if (Time.timeSinceLevelLoad  >= 0) {
			AnimationChange (State.SIT);
		}
	}

	void AnimationChange(State newState) {
		if (newState != currentState) {
			currentState = newState;

			switch (currentState) {
			case State.IDLE:
				if (Time.timeSinceLevelLoad  >= 20 && Time.timeSinceLevelLoad  <= 30){
					transform.Rotate(0, -120, 0);
				}
				if (Time.timeSinceLevelLoad  >= 35 && Time.timeSinceLevelLoad  <= 40){
					transform.Rotate(0, -90, 0);
				}
				break;
			case State.SIT: 
				transform.Rotate(0, -85, 0);
				break;
			}
			animator.SetInteger ("State", (int)newState);
		}
	}
}
