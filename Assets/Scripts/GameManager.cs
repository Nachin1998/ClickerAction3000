using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	private int maxScore = 10000;
	public static int score = 0;

    // Update is called once per frame
    void Update()
    {
	    if (score >= maxScore)
	    {
			SceneManager.LoadScene(2);
	    }
	}
}
