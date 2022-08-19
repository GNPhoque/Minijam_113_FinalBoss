using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Lazer : Attack
{
	[SerializeField] Transform lazerIndicatorPrefab;
	[SerializeField] Transform lazerPrefab;

	public override void Trigger()
	{
		Transform indicator = Instantiate(lazerIndicatorPrefab);
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
		Transform lazer = Instantiate(lazerPrefab);
		Destroy(lazer.gameObject, 1f);
	}
}
