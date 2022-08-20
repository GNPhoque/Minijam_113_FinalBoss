using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Character
{
	[Header("SceneReferences")]
	[SerializeField] ProgressBar healthBar;

	[Header("Components")]
	[SerializeField] CharacterMovement movement;
	[SerializeField] CharacterAttack attack;
	[SerializeField] CharacterCollisions collision;

	[Header("Stats")]
	[SerializeField] int maxHp;
	[SerializeField] int _currentHp;

	PlayerInputListener inputs;

	int currentHp
	{
		get => _currentHp;
		set
		{
			value = Mathf.Clamp(value, 0, maxHp);
			_currentHp = value;
			healthBar.BarValue = value;
			if (_currentHp <= 0) Die();
		}
	}

	#region MONOBEHAVIOUR
	private void Awake()
	{
		inputs = PlayerInputListener.instance;
		healthBar.BarValue = currentHp;
	}

	private void OnEnable()
	{
		inputs.OnMovementChanged += Inputs_OnMovementChanged;
		inputs.OnMeleeAttackPressed += Inputs_OnMeleeAttackPressed;
		inputs.OnMagicAttackPressed += Inputs_OnMagicAttackPressed;
		inputs.OnDEBUG_DAMAGEPressed += DEBUG_TakeDamage;
		inputs.OnDEBUG_HEALPressed += DEBUG_Heal;
	}

	private void OnDisable()
	{
		inputs.OnMovementChanged -= Inputs_OnMovementChanged;
		inputs.OnMeleeAttackPressed -= Inputs_OnMeleeAttackPressed;
		inputs.OnMagicAttackPressed -= Inputs_OnMagicAttackPressed;
		inputs.OnDEBUG_DAMAGEPressed -= DEBUG_TakeDamage;
		inputs.OnDEBUG_HEALPressed -= DEBUG_Heal;
	}
	#endregion

	#region INPUT EVENTS
	private void Inputs_OnMovementChanged(Vector2 obj)
	{
		movement.UpdateInput(obj);
	}

	private void Inputs_OnMeleeAttackPressed()
	{
		attack.MeleeAttack(transform.position, movement.IsLookingRight ? Vector2.right : Vector2.left, Vector2.zero);
	}

	private void Inputs_OnMagicAttackPressed()
	{
		attack.MagicAttack(transform.position, movement.IsLookingRight ? Vector2.right : Vector2.left, Vector2.zero);
	}
	#endregion

	private void DEBUG_TakeDamage()
	{
		TakeDamage(3);
	}

	private void DEBUG_Heal()
	{
		Heal(10);
	}

	#region Health
	void TakeDamage(int damage)
	{
		currentHp -= damage;
	}

	void Heal(int heal)
	{
		currentHp += heal;
	}

	void Die()
	{
		//Gameover
	}
	#endregion
}
