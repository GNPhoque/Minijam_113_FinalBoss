using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollisions : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Lazer"))
		{
			Debug.Log("Hit by lazer");
		}
	}
}
