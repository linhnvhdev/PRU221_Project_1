using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private List<Score> scores;
    public static ScoreManager instance;
    public string highscoreFile;
    private void Awake()
    {
        instance = this;
        scores = new List<Score>();
        highscoreFile = Application.dataPath + "/HighscoreText" + "/highscore.txt";
    }
    public IEnumerable<Score> GetHighscores()
    {
        return scores.OrderByDescending(x => x.score);
    }
    public void AddScore(Score score)
    {
        scores.Add(score);
    }
}
