using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GhostGameBehavior : MonoBehaviour {
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

	public GameObject ai;
	private Animator animator;
	private State currentState;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		ai.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad >= 51) {
			if (ai.activeInHierarchy && !animator.GetBool("PlayerMode")) {
				SceneManager.LoadScene (5);
			}
		} else if (Time.timeSinceLevelLoad  >= 50) {
			AnimationChange (State.IDLE);
			animator.SetFloat ("Speed", 1F);
			ai.SetActive (true);
			animator.SetBool ("PlayerMode", true);
		} else if (Time.timeSinceLevelLoad  >= 35) {
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
