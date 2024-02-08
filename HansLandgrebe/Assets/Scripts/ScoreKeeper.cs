using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] AudioSource scoreSound;
    [SerializeField] TextMeshProUGUI scoreText;
    private int score;

    public void Start()
    {
        scoreSound = GetComponent<AudioSource>();
    }

    public void addScore(int score)
    {
        this.score += score;
        scoreSound.Play();
        updateScoreText();
    }

    public void updateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    public int getScore()
    {
        return score;
    }

}
