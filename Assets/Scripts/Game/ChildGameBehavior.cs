using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChildGameBehavior : MonoBehaviour {
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
	bool playerMode;
	public float speed;
	private float h = 0.0f;
	private float v = 0.0f;
	private float directionDampTime = 0.25f;
	private State currentState;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		playerMode = animator.GetBool ("PlayerMode");
		if(animator.layerCount >= 2) {
			animator.SetLayerWeight(1, 1);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (playerMode) {
			if (animator) {
				h = Input.GetAxis ("Horizontal");
				v = Input.GetAxis ("Vertical");
				speed = new Vector2 (h, v).sqrMagnitude;

				animator.SetFloat ("LocomotionSpeed", speed);
				animator.SetFloat ("Direction", h, directionDampTime, Time.deltaTime);
			}
			if (Input.GetKeyUp("space")) {
				SceneManager.LoadScene (5);
			}
		} else {
			if (Time.timeSinceLevelLoad  >= 55) {
				AnimationChange (State.IDLE);
				playerMode = true;
				animator.SetBool("PlayerMode", true);
			} else if (Time.timeSinceLevelLoad  >= 35) {
				AnimationChange (State.TALK);
			} else if (Time.timeSinceLevelLoad  >= 32) {
				AnimationChange (State.IDLE);
			} else if (Time.timeSinceLevelLoad  >= 30) {
				animator.SetFloat ("Speed", 0.7F);
				AnimationChange (State.RUNJOG);
			} else if (Time.timeSinceLevelLoad  >= 25) {
				animator.SetBool ("LookAround", false);
			} else if (Time.timeSinceLevelLoad  >= 15) {
				AnimationChange (State.IDLE);
				animator.SetBool ("LookAround", true);
			} else if (Time.timeSinceLevelLoad  >= 0) {
				AnimationChange (State.CAREFULWALK);
			}
		}
	}

	void AnimationChange(State newState) {
		if (newState != currentState) {
			currentState = newState;

			switch (currentState) {
			case State.RUNJOG:
				transform.Rotate (0, -5, 0);
				break;
			}

			animator.SetInteger ("State", (int)newState);
		}
	}
}
