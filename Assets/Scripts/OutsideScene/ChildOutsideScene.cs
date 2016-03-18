using UnityEngine;
using System.Collections;

public class ChildOutsideScene : MonoBehaviour {
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

	public Animator animator;
	public bool rotate;
	private State currentState;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		currentState = State.IDLE;
		rotate = true;
		animator.SetFloat ("Speed", 1.0F);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad >= 100) {
			animator.ResetTrigger ("PickUp");
			Transform roseTransform = GameObject.FindWithTag ("Rose").transform;
			roseTransform.parent = GameObject.FindWithTag("LeftHand").transform;
			roseTransform.localPosition = new Vector3 (-0.046F, 0.062F, -0.192F);
			roseTransform.localEulerAngles = new Vector3 (50.41082F, 176.8193F, 162.0005F);
		} else if (Time.timeSinceLevelLoad  >= 97) {
			animator.SetTrigger ("PickUp");
		} else if (Time.timeSinceLevelLoad  >= 94) {
			animator.SetBool ("LookAround", false);
		} else if (Time.timeSinceLevelLoad  >= 92) {
			animator.SetBool ("LookAround", true);
		} else if (Time.timeSinceLevelLoad  >= 91) {
			AnimationChange (State.IDLE);
		} else if (Time.timeSinceLevelLoad  >= 90) {
			animator.ResetTrigger ("Lift");
			animator.SetBool ("LookAround", false);
			AnimationChange (State.RUNJOG);
		} else if (Time.timeSinceLevelLoad  >= 82) {
			animator.SetBool ("LookAround", true);
		} else if (Time.timeSinceLevelLoad  >= 80) {
			AnimationChange (State.IDLE);
		} else if (Time.timeSinceLevelLoad  >= 57) {
			AnimationChange (State.TALK);
		} else if (Time.timeSinceLevelLoad  >= 50) {
			if (rotate) {
				transform.Rotate (0, 135, 0);
				rotate = false;
			}
			animator.SetBool ("LookAround", false);
		} else if (Time.timeSinceLevelLoad  >= 40) {
			AnimationChange (State.IDLE);
			animator.SetBool ("LookAround", true);
		} else if (Time.timeSinceLevelLoad  >= 28) {
			animator.SetTrigger ("Lift");
		} else if (Time.timeSinceLevelLoad  >= 25) {
			AnimationChange (State.RUNJOG);
		} else if (Time.timeSinceLevelLoad  >= 18) {
			AnimationChange (State.IDLE);
		} else if (Time.timeSinceLevelLoad  >= 0) {
			AnimationChange (State.SCAREDWALK);
		}
	}

	void AnimationChange(State newState) {
		if (newState != currentState) {
			currentState = newState;

			switch (currentState) {
			case State.IDLE:
				if (Time.timeSinceLevelLoad  >= 80 && Time.timeSinceLevelLoad  < 90) {
					transform.Rotate (0, -135, 0);
				}
				break;
			case State.SCAREDWALK:
				transform.Rotate (0, 40, 0);
				break;
			case State.RUNJOG:
				if (Time.timeSinceLevelLoad  >= 25 && Time.timeSinceLevelLoad  < 90) {
					transform.Rotate (0, -90, 0);
				}
				if (Time.timeSinceLevelLoad  >= 90) {
					transform.Rotate (0, 135, 0);
				}
				break;
			}

			animator.SetInteger ("State", (int)newState);
		}
	}
}