using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Score
{
    public string date;
    public int score;

    public Score(string date, int score)
    {
        this.date = date;
        this.score = score;
    }
}
