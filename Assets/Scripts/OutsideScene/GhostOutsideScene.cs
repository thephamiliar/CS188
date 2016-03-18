using UnityEngine;
using System.Collections;

public class GhostOutsideScene : MonoBehaviour {
	enum State {
		IDLE = 0,
		WALK = 1,
		TALK = 2
	}

	public GameObject rose;
	private Animator animator;
	private State currentState;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		rose.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad  >= 80) {
			gameObject.SetActive (false);
			rose.SetActive (true);
		} else if (Time.timeSinceLevelLoad  >= 60) {
			AnimationChange (State.TALK);
		} else if (Time.timeSinceLevelLoad  >= 55) {
			AnimationChange (State.IDLE);
		} else if (Time.timeSinceLevelLoad  >= 52) {
			AnimationChange (State.WALK);
		} else if (Time.timeSinceLevelLoad  >= 0) {
			AnimationChange (State.IDLE);
		}
	}

	void AnimationChange(State newState) {
		if (newState != currentState) {
			currentState = newState;
			switch (currentState) {
			case State.WALK:
				transform.Rotate (0, 25, 0);
				break;
			}

			animator.SetInteger ("State", (int)newState);
		}
	}
}
