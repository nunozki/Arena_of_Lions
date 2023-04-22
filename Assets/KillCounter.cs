using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KillCounter : MonoBehaviour
{
	public int kills = 0;
	public TextMeshProUGUI counterText;

	private void Start()
	{
		UpdateCounterText();
	}

	public void IncrementKills()
	{
		kills++;
		UpdateCounterText();
	}

	private void UpdateCounterText()
	{
		counterText.text = $"Kills: {kills}";
	}
}
