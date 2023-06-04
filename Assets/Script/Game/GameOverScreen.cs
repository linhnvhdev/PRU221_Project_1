using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class GameOverScreen : MonoBehaviour
{
    string highscoreFile;
    private void Start()
    {
        highscoreFile = Application.dataPath + "/HighscoreText" + "/highscore.txt";
    }
    public void Setup(int score)
    {
        gameObject.SetActive(true);
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //save highscore
        SaveHighscore();
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        //save highscore
        SaveHighscore();
    }
    private void SaveHighscore()
    {
        int score = GameManager.instance.score.score;
        string timeNow = DateTime.Now.ToString("dd/MM/yyyy");
        string toWrite = "";
        toWrite = timeNow.ToString()+"-"+score.ToString();
        ReadWriteFromFile.instance.AppendText(highscoreFile, toWrite);
    }
}
