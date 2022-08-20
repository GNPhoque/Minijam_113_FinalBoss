using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputListener : MonoBehaviour
{
	#region EVENTS
	public event Action OnUiUpPressed;
	public event Action OnUiDownPressed;
	public event Action OnUiConfirmPressed;

	public event Action OnMeleeAttackPressed;
	public event Action OnMagicAttackPressed;
	public event Action OnDEBUG_DAMAGEPressed;
	public event Action OnDEBUG_HEALPressed;

	public event Action<Vector2> OnMovementChanged;
	#endregion

	#region INPUTS
	protected void UiUpPressed() => OnUiUpPressed?.Invoke();
	protected void UiDownPressed() => OnUiDownPressed?.Invoke();
	protected void UiConfirmPressed() => OnUiConfirmPressed?.Invoke();

	protected void MeleeAttackPressed() => OnMeleeAttackPressed?.Invoke();
	protected void MagicAttackPressed() => OnMagicAttackPressed?.Invoke();
	protected void DEBUG_DAMAGEPressed() => OnDEBUG_DAMAGEPressed?.Invoke();
	protected void DEBUG_HEALPressed() => OnDEBUG_HEALPressed?.Invoke();

	protected void MovementChanged(Vector2 direction) => OnMovementChanged?.Invoke(direction); 
	#endregion
}
