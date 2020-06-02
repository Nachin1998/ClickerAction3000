using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{

	public static ScenesManager Instance { get; private set; }
	private void Awake()
	{
		if(Instance == null)
		{
			Instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);	
		}
	}

	public void GoToMainMenu()
	{
		SceneManager.LoadScene(0);
	}

	public void StartGame()
	{
		SceneManager.LoadScene(1);
	}

	public void RestartGame()
	{
		GameManager.score = 0;
		SceneManager.LoadScene(0);
	}

	public void GoToCredits()
	{
		SceneManager.LoadScene(3);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
