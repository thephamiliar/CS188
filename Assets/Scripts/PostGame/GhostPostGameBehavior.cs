using UnityEngine;
using System.Collections;

public class GhostPostGameBehavior : MonoBehaviour {
	enum State {
		IDLE = 0,
		WALK = 1,
		TALK = 2
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
		if (Time.timeSinceLevelLoad  >= 30) {
			AnimationChange (State.IDLE);
		} else if (Time.timeSinceLevelLoad  >= 10) {
			AnimationChange (State.TALK);
		} else if (Time.timeSinceLevelLoad  >= 0) {
			AnimationChange (State.IDLE);
		}
	}

	void AnimationChange(State newState) {
		if (newState != currentState) {
			currentState = newState;
			animator.SetInteger ("State", (int)newState);
		}
	}
}
