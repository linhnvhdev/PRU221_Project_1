using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] Text txt_score;

    public int defaultScore;

    public int score;
    public void Init()
    {
        score = defaultScore;
        txt_score.text = score.ToString();
    }

    public void GainScore()
    {
        score++;
        txt_score.text = score.ToString();
    }
}
