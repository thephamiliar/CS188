using UnityEngine;
using System.Collections;

public class AdultBehavior2 : MonoBehaviour {
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
		if (Time.timeSinceLevelLoad  >= 64) {
			AnimationChange (State.LEANDOWN);
		} else if (Time.timeSinceLevelLoad  >= 60) {
			AnimationChange (State.IDLE);
		} else if (Time.timeSinceLevelLoad  >= 57) {
			AnimationChange (State.STERNWALK);
		} else if (Time.timeSinceLevelLoad  >= 43) {
			AnimationChange (State.IDLE);
		} else if (Time.timeSinceLevelLoad  >= 12) {
			AnimationChange (State.TALK);
		}
	}

	void AnimationChange(State newState) {
		if (newState != currentState) {
			currentState = newState;

			switch (currentState) {
			case State.TALK:
				transform.Rotate (0, -60, 0);
				break;
			}
			animator.SetInteger ("State", (int)newState);
		}
	}
}
