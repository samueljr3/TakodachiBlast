using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void AddScore(int points)
    {
        score += points;
        scoreText.text="Score: " + score;
    }
}
