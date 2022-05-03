using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour
{
    public Text bestScoreTxt;
    public Text currentScoreTxt;

    int currentScore;
    int bestScore;

    private void Start()
    {
        currentScore = PlayerPrefs.GetInt("Current Score", 0);
        currentScoreTxt.text = "�������� : " + currentScore;
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        bestScoreTxt.text = "�ְ����� : " + bestScore;


    }
    public void BtnRestart(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
