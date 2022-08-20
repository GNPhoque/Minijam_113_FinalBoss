using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Lazer : Attack
{
	[SerializeField] Transform lazerIndicatorPrefab;
	[SerializeField] Transform lazerPrefab;
	[SerializeField] float spawnOffset;
	Vector3 spawnPos;

	public override void Trigger(Vector2 sourcePosition, Vector2 direction, Vector2 targetPosition)
	{
		spawnPos = sourcePosition + direction * spawnOffset;
		Transform indicator = Instantiate(lazerIndicatorPrefab, spawnPos, Quaternion.identity);
		StaticMonobehaviour.instance.StartCoroutine(IncreaseWidth(indicator));
	}


	IEnumerator IncreaseWidth(Transform indicator)
	{
		float time = 0f;
		while (time < 1f)
		{
			yield return null;

			Vector3 newScale = indicator.localScale;
			time += Time.deltaTime;
			newScale.x += time;

			indicator.localScale = newScale;
		}
		Destroy(indicator.gameObject);
		Transform lazer = Instantiate(lazerPrefab, spawnPos, Quaternion.identity);
		Destroy(lazer.gameObject, 1f);
	}
}
