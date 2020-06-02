using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
	public TMP_Text goldAmmountText;
	public List<PlayerButton> playerButtons = new List<PlayerButton>();

	void Update()
	{
		goldAmmountText.text = "Gold:" + GameManager.score;

		for (int i = 0; i < playerButtons.Count; i++)
		{
			SetButtonActive(playerButtons[i], playerButtons[i].pointsNeededToActivate);
		}
	}

	void SetButtonActive(PlayerButton button, int pointsNeededToActivate)
	{
		if (GameManager.score >= pointsNeededToActivate)
		{
			button.gameObject.SetActive(true);
		}
        else
        {
            button.gameObject.SetActive(false);
        }
    }

    public void OnClick(int points)
    {
        GameManager.score += points;
    }
}
