using UnityEngine;
using System.Collections;

public class ChildBehavior2 : MonoBehaviour {
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
		if (Time.timeSinceLevelLoad >= 80) {
			AnimationChange (State.RUNJOG);
		} else if (Time.timeSinceLevelLoad >= 78) {
			animator.ResetTrigger ("SetDown");
			Transform roseTransform = GameObject.FindWithTag ("Rose").transform;
			roseTransform.parent = GameObject.FindWithTag("Vase").transform;
			roseTransform.localPosition = new Vector3(-0.051F, 0.087F, 0.719F);
			roseTransform.localEulerAngles = Vector3.zero;
		} else if (Time.timeSinceLevelLoad  >= 77) {
			animator.SetTrigger ("SetDown");
		} else if (Time.timeSinceLevelLoad  >= 75) {
			AnimationChange (State.IDLE);
		} else if (Time.timeSinceLevelLoad  >= 65) {
			animator.SetFloat ("Speed", 0.4F);
			AnimationChange (State.RUNJOG);
		} else if (Time.timeSinceLevelLoad  >= 62) {
			animator.SetBool ("LookAround", false);
		} else if (Time.timeSinceLevelLoad  >= 45) {
			animator.SetBool ("LookAround", true);
		} else if (Time.timeSinceLevelLoad  >= 0) {
			AnimationChange (State.IDLE);
		}
	}

	void AnimationChange(State newState) {
		if (newState != currentState) {
			currentState = newState;
			switch (currentState) {
			case State.RUNJOG: 
				if (Time.timeSinceLevelLoad  >= 65 && Time.timeSinceLevelLoad  <= 75) {
					transform.Rotate (0, 180-transform.eulerAngles.y, 0);
				} else {
					transform.Rotate (0, 180, 0);
				}
				break;
			}
			animator.SetInteger ("State", (int)newState);
		}
	}
}
