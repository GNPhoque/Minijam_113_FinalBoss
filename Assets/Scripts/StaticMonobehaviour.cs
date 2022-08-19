using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticMonobehaviour : MonoBehaviour
{
	public static StaticMonobehaviour instance;

	private void Awake()
	{
		if (instance) Destroy(instance);
		instance = this;
	}
}
