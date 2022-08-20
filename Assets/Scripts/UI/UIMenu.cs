using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMenu : MonoBehaviour
{
	[SerializeField] UIElement[] uiElements;

	PlayerInputListener inputs;
	int currentElementIndex;

	private void Awake()
	{
		inputs = PlayerInputListener.instance;
		inputs.ToggleUIInputs();
	}

	private void OnEnable()
	{
		SetupInputEvents();

		ShowSelectedElementVisuals();
	}

	private void OnDisable()
	{
		RemoveInputEvents();
	}

	private void SetupInputEvents()
	{
		inputs.OnUiUpPressed += UP_performed;
		inputs.OnUiDownPressed += DOWN_performed;
		inputs.OnUiConfirmPressed += CONFIRM_performed;
	}

	private void RemoveInputEvents()
	{
		inputs.OnUiUpPressed -= UP_performed;
		inputs.OnUiDownPressed -= DOWN_performed;
		inputs.OnUiConfirmPressed -= CONFIRM_performed;
	}

	private void UP_performed()
	{
		HideSelectedElementVisuals();
		if (currentElementIndex == 0) currentElementIndex = uiElements.Length - 1;
		else currentElementIndex -= 1;
		ShowSelectedElementVisuals();
		AudioManager.instance.PlayUIMove();
	}

	private void DOWN_performed()
	{
		HideSelectedElementVisuals();
		if (currentElementIndex == uiElements.Length - 1) currentElementIndex = 0;
		else currentElementIndex += 1;
		ShowSelectedElementVisuals();
		AudioManager.instance.PlayUIMove();
	}

	private void CONFIRM_performed()
	{
		uiElements[currentElementIndex].Activate();
		AudioManager.instance.PlayUISelect();
	}

	void HideSelectedElementVisuals()
	{
		uiElements[currentElementIndex].MoveCursorOff();
	}

	void ShowSelectedElementVisuals()
	{
		uiElements[currentElementIndex].MoveCursorOn();
	}
}
