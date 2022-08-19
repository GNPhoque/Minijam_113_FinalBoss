using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMovement : MonoBehaviour
{
	[Header("MOVEMENT")]
	[SerializeField] float maxSpeed;
	[SerializeField] float moveSpeed;
	[SerializeField] float jumpSpeed;
	[SerializeField] float smoothInputSpeed;
	[SerializeField] LayerMask groundLayer;

	[Header("COMPONENTS")]
	[SerializeField] Rigidbody2D rb;
	[SerializeField] SpriteRenderer spriteRenderer;

	bool mustJump;
	bool stopJump;
	Vector2 smoothInputVelocity;
	Vector2 currentMovementVector;
	Vector2 lastDirection;

	PlayerInputs inputs;
	Vector2 currentDirection;

	#region MONOBEHAVIOUR
	private void Awake()
	{
		inputs = new PlayerInputs();
	}

	private void OnEnable()
	{
		inputs.Movement.Direction.performed += Direction_performed;
		inputs.Movement.Direction.canceled += Direction_performed;
		inputs.Movement.Jump.performed += Jump_performed;
		inputs.Movement.Jump.canceled += Jump_canceled;

		inputs.Enable();
	}

	private void OnDisable()
	{
		inputs.Movement.Direction.performed -= Direction_performed;
		inputs.Movement.Direction.canceled -= Direction_performed;
	}

	private void Update()
	{
		currentMovementVector = Vector2.SmoothDamp(currentMovementVector, currentDirection, ref smoothInputVelocity, smoothInputSpeed);
		if (currentMovementVector != Vector2.zero) lastDirection = currentMovementVector.normalized;

		if (currentMovementVector.x < 0) spriteRenderer.flipX = true;
		else spriteRenderer.flipX = false;
	}

	private void FixedUpdate()
	{
		Vector3 newVelocity = rb.velocity;
		newVelocity.x = currentMovementVector.x * moveSpeed;
		//rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
		if (mustJump)
		{
			mustJump = false;
			stopJump = false;
			newVelocity.y = jumpSpeed;
		}
		else if (newVelocity.y > .5f && stopJump)
		{
			newVelocity.y *= .2f;
			stopJump = false;
		}
		rb.velocity = newVelocity;
	}
	#endregion

	#region EVENTS
	private void Direction_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
	{
		currentDirection = obj.ReadValue<Vector2>();
	}

	private void Jump_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
	{
		if (IsGrounded())
		{
			mustJump = true;
		}
	}

	private void Jump_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
	{
		stopJump = true;
	}
	#endregion

	bool IsGrounded()
	{
		return Physics2D.OverlapCircle(rb.position, .2f, groundLayer);
	}
}
