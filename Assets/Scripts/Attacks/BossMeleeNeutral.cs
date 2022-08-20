using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BossMeleeNeutral : Attack
{
	[SerializeField] Transform bossMeleeNeutralPrefab;
	[SerializeField] float duration;
	[SerializeField] float spawnOffset;

	public override void Trigger(Vector2 sourcePosition, Vector2 direction, Vector2 targetPosition)
	{
		Transform fx = Instantiate(bossMeleeNeutralPrefab, sourcePosition + direction * spawnOffset, Quaternion.identity);
		Destroy(fx.gameObject, duration);
	}
}
