using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAttack : MonoBehaviour
{
	[SerializeField] Attack[] meleeAttacks;
	[SerializeField] Attack[] magicAttacks;

	public void MeleeAttack(Vector2 sourcePosition, Vector2 direction, Vector2 targetPosition)
	{
		meleeAttacks[0].Trigger(sourcePosition, direction, targetPosition);
	}

	public void MagicAttack(Vector2 sourcePosition, Vector2 direction, Vector2 targetPosition)
	{
		magicAttacks[0].Trigger(sourcePosition, direction, targetPosition);
	}
}
