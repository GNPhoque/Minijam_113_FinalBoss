using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputListener : InputListener
{
	PlayerInputs inputs;
	public static PlayerInputListener instance;

	#region MONOBEHAVIOUR
	private void Awake()
	{
		if (instance) Destroy(instance.gameObject);
		instance = this;

		DontDestroyOnLoad(this);

		inputs = new PlayerInputs();
	}

	private void OnEnable()
	{
		inputs.UI.UP.performed += UP_performed;
		inputs.UI.DOWN.performed += DOWN_performed;
		inputs.UI.CONFIRM.performed += CONFIRM_performed;

		inputs.Movement.Direction.performed += Direction_performed;
		inputs.Movement.Direction.canceled += Direction_performed;

		inputs.Attack.Melee.performed += Melee_performed;
		inputs.Attack.Magic.performed += Magic_performed;
		inputs.Attack.DEBUG_Damage.performed += DEBUG_Damage_performed;
		inputs.Attack.DEBUG_Heal.performed += DEBUG_Heal_performed;

	}

	private void OnDisable()
	{
		inputs.UI.UP.performed -= UP_performed;
		inputs.UI.DOWN.performed -= DOWN_performed;
		inputs.UI.CONFIRM.performed -= CONFIRM_performed;

		inputs.Movement.Direction.performed -= Direction_performed;
		inputs.Movement.Direction.canceled -= Direction_performed;

		inputs.Attack.Melee.performed -= Melee_performed;
		inputs.Attack.Magic.performed -= Magic_performed;
		inputs.Attack.DEBUG_Damage.performed -= DEBUG_Damage_performed;
		inputs.Attack.DEBUG_Heal.performed -= DEBUG_Heal_performed;
	} 
	#endregion

	#region INPUT EVENTS
	#region UI
	private void UP_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
	{
		UiUpPressed();
	}

	private void DOWN_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
	{
		UiDownPressed();
	}

	private void CONFIRM_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
	{
		UiConfirmPressed();
	}
	#endregion

	#region ATTACK
	private void Melee_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
	{
		MeleeAttackPressed();
	}

	private void Magic_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
	{
		MagicAttackPressed();
	}

	private void DEBUG_Damage_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
	{
		DEBUG_DAMAGEPressed();
	}

	private void DEBUG_Heal_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
	{
		DEBUG_HEALPressed();
	}
	#endregion

	#region MOVEMENT
	private void Direction_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
	{
		MovementChanged(obj.ReadValue<Vector2>());
	}
	#endregion
	#endregion

	public void ToggleUIInputs(bool toggle = true)
	{
		if (toggle) inputs.UI.Enable();
		else inputs.UI.Disable();
	}

	public void ToggleAttackInputs(bool toggle = true)
	{
		if (toggle) inputs.Attack.Enable();
		else inputs.Attack.Disable();
	}

	public void ToggleMovementInputs(bool toggle = true)
	{
		if (toggle) inputs.Movement.Enable();
		else inputs.Movement.Disable();
	}
}
