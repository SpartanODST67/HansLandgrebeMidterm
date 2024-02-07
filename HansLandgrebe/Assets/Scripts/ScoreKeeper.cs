using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] AudioSource scoreSound;
    [SerializeField] int score;

    public void addScore(int score)
    {
        this.score += score;
    }

    public int getScore()
    {
        return score;
    }

}
