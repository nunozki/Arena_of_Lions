using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public GameObject playerGO;
	public void RestartScene()
	{
		Destroy(playerGO);
		StartCoroutine(LoadScene());
	}
	IEnumerator LoadScene()
	{
		yield return new WaitForSeconds(5.0f);
		SceneManager.LoadScene("SampleScene");
	}
}
