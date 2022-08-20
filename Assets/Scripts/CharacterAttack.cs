using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAttack : MonoBehaviour
{
	[SerializeField] Attack[] attacks;
	PlayerInputs inputs;

	private void Awake()
	{
		inputs = new PlayerInputs();
	}

	private void OnEnable()
	{
		inputs.Attack.Melee.performed += Melee_performed;
		inputs.Attack.Magic.performed += Magic_performed;
		inputs.Enable();
	}

	private void OnDisable()
	{
		inputs.Attack.Melee.performed -= Melee_performed;
		inputs.Attack.Magic.performed -= Magic_performed;
	}

	private void Melee_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
	{
		attacks[0].Trigger();
	}

	private void Magic_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
	{
		attacks[0].Trigger();
	}
}
