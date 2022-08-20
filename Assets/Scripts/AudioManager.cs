using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	[SerializeField] AudioClip[] bossHits;
	[SerializeField] AudioClip[] bossAttacks;
	[SerializeField] AudioClip[] adventurerHits;
	[SerializeField] AudioClip[] adventurerAttacks;

	[SerializeField] AudioClip bossDeath;
	[SerializeField] AudioClip adventurerDeath;
	[SerializeField] AudioClip uiMove;
	[SerializeField] AudioClip uiSelect;

	AudioSource audioSource;

	public static AudioManager instance;

	private void Awake()
	{
		if (instance) Destroy(instance.gameObject);
		instance = this;

		DontDestroyOnLoad(this);
		audioSource = GetComponent<AudioSource>();
	}


	public void PlayBossAttack()
	{
		AudioClip clip = bossAttacks[Random.Range(0, bossAttacks.Length)];
		PlaySound(clip);
	}

	public void PlayBossHit()
	{
		AudioClip clip = bossHits[Random.Range(0, bossHits.Length)];
		PlaySound(clip);
	}

	public void PlayBossDeath()
	{
		AudioClip clip = bossDeath;
		PlaySound(clip);
	}

	public void PlayAdventurerAttack()
	{
		AudioClip clip = adventurerAttacks[Random.Range(0, adventurerAttacks.Length)];
		PlaySound(clip);
	}

	public void PlayAdventurerHit()
	{
		AudioClip clip = adventurerHits[Random.Range(0, adventurerHits.Length)];
		PlaySound(clip);
	}

	public void PlayAdventurerDeath()
	{
		AudioClip clip = adventurerDeath;
		PlaySound(clip);
	}

	public void PlayUIMove()
	{
		AudioClip clip = uiMove;
		PlaySound(clip);
	}

	public void PlayUISelect()
	{
		AudioClip clip = uiSelect;
		PlaySound(clip);
	}

	public void PlaySound(AudioClip clip)
	{
		audioSource.PlayOneShot(clip);
	}
}
