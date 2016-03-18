using UnityEngine;
using System.Collections;

public class ChildIntroGameBehavior : MonoBehaviour {
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
