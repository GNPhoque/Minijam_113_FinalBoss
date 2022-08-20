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

	bool isLookingRight;
	bool mustJump;
	bool stopJump;
	Vector2 smoothInputVelocity;
	Vector2 currentMovementVector;
	Vector2 lastDirection;

	Vector2 currentDirection;

	#region MONOBEHAVIOUR
	private void Update()
	{
		currentMovementVector = Vector2.SmoothDamp(currentMovementVector, currentDirection, ref smoothInputVelocity, smoothInputSpeed);
		if (currentMovementVector != Vector2.zero) lastDirection = currentMovementVector.normalized;

		if (currentMovementVector.x < 0) isLookingRight = false;
		else if (currentMovementVector.x > 0) isLookingRight = true;
		spriteRenderer.flipX = isLookingRight;
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

	public void UpdateInput(Vector2 newInput)
	{
		currentDirection = newInput;
	}

	private void Jump_performed()
	{
		if (IsGrounded())
		{
			mustJump = true;
		}
	}

	private void Jump_canceled()
	{
		stopJump = true;
	}

	bool IsGrounded()
	{
		return Physics2D.OverlapCircle(rb.position, .2f, groundLayer);
	}

	public bool IsLookingRight => isLookingRight;
}
