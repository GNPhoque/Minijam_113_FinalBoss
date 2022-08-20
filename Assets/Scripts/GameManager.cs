using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	private void Awake()
	{
		PlayerInputListener.instance.ToggleAttackInputs();
		PlayerInputListener.instance.ToggleMovementInputs();
	}
}
