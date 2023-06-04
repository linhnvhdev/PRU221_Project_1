using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Score
{
    public string date;
    public string score;

    public Score(string date, string score)
    {
        this.date = date;
        this.score = score;
    }
}
