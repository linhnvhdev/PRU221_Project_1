using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public RowUI rowUI;
    public ScoreManager scoreManager;
    void Start()
    {
        string[] lines = ReadWriteFromFile.instance.ReadText(ScoreManager.instance.highscoreFile);
        foreach (string line in lines)
        {
            string[] data = line.Split('-');
            scoreManager.AddScore(new Score(data[0], int.Parse(data[1])));
        }
        var scores = scoreManager.GetHighscores().ToArray();
        if (scores.Length < 5)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                var row = Instantiate(rowUI, transform).GetComponent<RowUI>();
                row.rank.text = (i + 1).ToString();
                row.date.text = scores[i].date.ToString();
                row.score.text = scores[i].score.ToString();
            }
        }
        else
        {
            for (int i = 0; i < 5; i++)
            {
                var row = Instantiate(rowUI, transform).GetComponent<RowUI>();
                row.rank.text = (i + 1).ToString();
                row.date.text = scores[i].date.ToString();
                row.score.text = scores[i].score.ToString();
            }
        }
        
    }


}
