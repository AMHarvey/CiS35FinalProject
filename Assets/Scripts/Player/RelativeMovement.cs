using UnityEngine;
using System.Collections;

// 3rd-person movement that picks direction relative to target (usually the camera)
// commented lines demonstrate snap to direction and without ground raycast
//
// To setup animated character create an animation controller with states for idle, running, jumping
// transition between idle and running based on added Speed float, set those not atomic so that they can be overridden by...
// transition both idle and running to jump based on added Jumping boolean, transition back to idle

[RequireComponent(typeof(CharacterController))]
public class RelativeMovement : MonoBehaviour {
	[SerializeField] private Transform target;
	
	public float moveSpeed = 6.0f;
	public float rotSpeed = 15.0f;
	public float deceleration = 25.0f;
	public float targetBuffer = 1.75f;
	private float _curSpeed = 0.0f;
	private Vector3 _targetPos = Vector3.one;

	private float _vertSpeed = 0.0f;

	private CharacterController _charController;
	private Animator _animator;

	// Use this for initialization
	void Start() {
		_charController = GetComponent<CharacterController>();
		_animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update() {
		Vector3 movement = Vector3.zero;

		if (Input.GetMouseButtonDown(0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				if(!hit.collider.gameObject.Equals(this.gameObject)) {
					_targetPos = hit.transform.position;
					_curSpeed = moveSpeed;
				}
			}
		}

		if (_targetPos != Vector3.one) {
			Vector3 adjustedPos = new Vector3 (_targetPos.x, transform.position.y, _targetPos.z);
			Quaternion targetRot = Quaternion.LookRotation (adjustedPos - transform.position);
			transform.rotation = Quaternion.Slerp (transform.rotation, targetRot, rotSpeed * Time.deltaTime);
			movement = _curSpeed * Vector3.forward;
			movement = transform.TransformDirection (movement);

			if (Vector3.Distance (_targetPos, transform.position) < targetBuffer) {
				_curSpeed -= deceleration * Time.deltaTime;
				if (_curSpeed <= 0) {
					_targetPos = Vector3.one;
				}

			}

		}
		//_animator.SetFloat("Speed", movement.sqrMagnitude);
		movement *= Time.deltaTime;
		_charController.Move(movement);
	}
}

