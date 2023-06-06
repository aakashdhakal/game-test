using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public int highScore;
    public Text scoreText;
    public Text highScoreText;
    public Text GameOverhighScoreText;
    public Text GameOverScoreText;
    public GameObject GameOverScreen;
   
    public GameObject PlayerScore;
    public GameObject HighScore;
    public GameObject HighScoreText;
    public GameObject PlayerScoreText;
    public AudioSource GameOverAudio;
    public bool isGameOver = false;


    void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore", highScore);
        highScoreText.text = highScore.ToString();
    }

    [ContextMenu("Increase Score")]
    public void AddScore(int ScoreToAdd)
    {

        if (isGameOver)
        {
            ScoreToAdd = 0;
        }
        playerScore += ScoreToAdd;
        scoreText.text = playerScore.ToString();

        if(playerScore > highScore) {
            highScore = playerScore;
            highScoreText.text = highScore.ToString();

        }
    }
   

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void GameOver()
    {
        GameOverAudio.Play();
        Debug.Log("fuck");
        isGameOver = true;
        PlayerPrefs.SetInt("highScore", highScore);
        GameOverScreen.SetActive(true);
        GameOverhighScoreText.text = highScoreText.text;
        GameOverScoreText.text = scoreText.text;
        PlayerScore.SetActive(false);
        HighScore.SetActive(false);
        PlayerScoreText.SetActive(false);
        HighScoreText.SetActive(false);
        

    }
    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }

}
