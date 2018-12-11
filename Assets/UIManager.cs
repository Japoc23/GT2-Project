using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public RawImage dimmer;
    public Button[] buttonsToBeHidden;
    public Button[] buttonsToBeShown;
    public Text scoreText;
    public Text multiplierText;
    public Text leaderboardText;
    int score;
    bool gameOver;

	// Use this for initialization
	void Start () {
        gameOver = false;
        score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 0.5f);

        initSpeed();

        if (leaderboardText)
        {
            updateLeaderboardText();
        }
	}

    void scoreUpdate()
    {
        if (!gameOver) { 
            score += (globalVariables.startFaster ? 1 : 0) + (globalVariables.lessDistance ? 1 : 0) + (globalVariables.visibleLater ? 1 : 0) + 1;
            globalVariables.speed += 0.01f;
        }

    }

    public void setGameOver()
    {
        globalVariables.speed = 0f;
        gameOver = true;

        foreach(Button button in buttonsToBeShown)
        {
            button.gameObject.SetActive(true);
        }

        foreach (Button button in buttonsToBeHidden)
        {
            button.gameObject.SetActive(false);
        }

        dimmer.gameObject.SetActive(true);
        globalVariables.addScore(score);
    }
	
	// Update is called once per frame
	void Update () {

        if (scoreText) { 
        scoreText.text = "Score: " + score;
        }

        if (multiplierText)
        {
            multiplierText.text = "Current multiplier: x" + ((globalVariables.startFaster ? 1f : 0f) + (globalVariables.lessDistance ? 1f : 0f) + (globalVariables.visibleLater ? 1f : 0f) + 1f);
        }


    }

    public void Play()
    {
        SceneManager.LoadScene("MainScene");

        initSpeed();
    }

    public void Pause()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        initSpeed();
    }

    public void Options()
    {
        SceneManager.LoadScene("OptionScene");
    }

    public void Leaderboard()
    {
        SceneManager.LoadScene("LeaderboardScene");
    }

    public void updateLeaderboardText()
    {
        int[] scores = globalVariables.getScores();
        int i = 1;
        foreach(int score in scores) {
            if (i < 11 && score != 0) {
                leaderboardText.text += i + ".   -  " + score + "\n";
                i++;

            }
        }

    }

    private void initSpeed()
    {
        if (globalVariables.startFaster)
        {
            globalVariables.speed = 3f;
        }
        else
        {
            globalVariables.speed = 2f;
        }
    }

}
