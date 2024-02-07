using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] int score = 1;
    private ScoreKeeper scoreKeeper;

    public void setScoreKeeper(ScoreKeeper scoreKeeper)
    {
        this.scoreKeeper = scoreKeeper;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            scoreKeeper.addScore(score);
            Destroy(gameObject);
        }
    }
}
