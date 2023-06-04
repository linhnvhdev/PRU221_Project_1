using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting.AssemblyQualifiedNameParser;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] Text txt_score;
    [SerializeField] Text txt_highscore;

    public int defaultScore;
    public int score;
    string highscoreFile;

    public void Init()
    {
        score = defaultScore;
        txt_score.text = score.ToString();
        highscoreFile = Application.dataPath + "/HighscoreText" + "/highscore.txt";
        GetHighscore();
    }
    public void Start()
    {
        
    }
    public void GainScore()
    {
        score++;
        txt_score.text = score.ToString();
    }

    public void GetHighscore()
    {
        try
        {
            if (ReadWriteFromFile.instance.ReadText(highscoreFile) != null)
            {
                string[] lines = ReadWriteFromFile.instance.ReadText(highscoreFile);
                List<int> scores = new List<int>();
                foreach (string line in lines)
                {
                    string[] component = line.Split('-');
                    scores.Add(int.Parse(component[1]));
                }
                txt_highscore.text = scores.Max().ToString();
            }
            else
            {
                txt_highscore.text = "0";
            }
        }catch (Exception ex)
        {
            Debug.LogException(ex);
        }
             
    }
}
