using UnityEngine;
using System.Collections;

public class AdultIntroGameBehavior : MonoBehaviour {

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
		if (Time.timeSinceLevelLoad  >= 0) {
			AnimationChange (State.SLEEP);
		}
	}

	void AnimationChange(State newState) {
		if (newState != currentState) {
			currentState = newState;
			animator.SetInteger ("State", (int)newState);
		}
	}
}
