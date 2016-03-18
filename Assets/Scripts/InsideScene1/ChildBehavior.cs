using UnityEngine;
using System.Collections;

public class ChildBehavior : MonoBehaviour {
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
	private State currentState;
	private bool triggerSadWalk;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		triggerSadWalk = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad  >= 53) {
			animator.SetTrigger ("SadWalk");
			if (!triggerSadWalk) {
				transform.localPosition = new Vector3(1F, 1F, 0F);
				triggerSadWalk = true;
			}
		} else if (Time.timeSinceLevelLoad  >= 35) {
			AnimationChange (State.SADWALK);
		} else if (Time.timeSinceLevelLoad  >= 21) {
			animator.SetTrigger ("Trip");
			AnimationChange (State.IDLE);
		} else if (Time.timeSinceLevelLoad  >= 18) {
			AnimationChange (State.HAPPY);
		} else if (Time.timeSinceLevelLoad  >= 0) {
			AnimationChange (State.IDLE);
		}
	}

	void AnimationChange(State newState) {
		if (newState != currentState) {
			currentState = newState;

			switch (currentState) {
			case State.HAPPY:
				transform.Rotate (0, -75, 0);
				break;
			}

			animator.SetInteger ("State", (int)newState);
		}
	}

	public float pushPower = 2.0F;
	void OnControllerColliderHit(ControllerColliderHit hit) {
		Rigidbody body = hit.collider.attachedRigidbody;
		if (body == null || body.isKinematic)
			return;

		if (hit.moveDirection.y < -0.3F)
			return;

		Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
		body.velocity = pushDir * pushPower;
	}
}
