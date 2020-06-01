using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
	public GameObject click01;
	public GameObject click02;
	public GameObject click03;
	public GameObject click04;

	public TMP_Text t;


	// Start is called before the first frame update
	void SetButtonActive(GameObject button, int pointsToActivate)
	{
		if (GameManager.score > pointsToActivate)
		{
			button.SetActive(true);
		}
		else
		{
			button.SetActive(false);
		}
	}

	void Update()
	{
		t.text = "Gold:" + GameManager.score;

		SetButtonActive(click01, 10);
		SetButtonActive(click02, 50);
		SetButtonActive(click03, 100);
		SetButtonActive(click04, 200);
	}

	public void Click01()
	{
		GameManager.score += 1;
	}

	public void Click02()
	{
		GameManager.score += 2;
	}

	public void Click03()
	{
		GameManager.score += 5;
	}

	public void Click04()
	{
		GameManager.score += 10;
	}

	public void Click05()
	{
		GameManager.score += 50;
	}
}
