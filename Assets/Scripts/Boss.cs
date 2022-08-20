using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
	[SerializeField] ProgressBar healthBar;

	[SerializeField] int maxHp;
	[SerializeField] int _currentHp;

	InputListener inputs;

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
		inputs.OnDEBUG_DAMAGEPressed += DEBUG_Damage_performed;
		inputs.OnDEBUG_HEALPressed += DEBUG_Heal_performed;
	}

	private void OnDisable()
	{
		inputs.OnDEBUG_DAMAGEPressed -= DEBUG_Damage_performed;
		inputs.OnDEBUG_HEALPressed -= DEBUG_Heal_performed;
	} 
	#endregion



	#region EVENTS
	private void DEBUG_Damage_performed()
	{
		TakeDamage(3);
	}

	private void DEBUG_Heal_performed()
	{
		Heal(10);
	} 
	#endregion


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
}
