using UnityEngine;
using System.Collections;

public class ChildPostGameBehavior : MonoBehaviour {
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
	public Animator animator;
	private State currentState;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		spiral.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad  >= 37) {
			gameObject.SetActive (false);
		} else if (Time.timeSinceLevelLoad  >= 30) {
			AnimationChange (State.IDLE);
			spiral.SetActive (true);
			animator.SetBool ("LookAround", true);
		} else if (Time.timeSinceLevelLoad  >= 15) {
			AnimationChange (State.TALK);
		} else if (Time.timeSinceLevelLoad  >= 6) {
			AnimationChange (State.IDLE);
		} else if (Time.timeSinceLevelLoad  >= 2) {
			animator.SetFloat ("Speed", 0.7F);
			AnimationChange (State.RUNJOG);
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
