using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Attack : ScriptableObject
{
	public abstract void Trigger(Vector2 sourcePosition, Vector2 direction, Vector2 targetPosition);
}
