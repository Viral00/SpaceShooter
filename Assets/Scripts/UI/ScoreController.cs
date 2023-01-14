using TMPro;
using UnityEngine;

public class ScoreController : MonoSingleton<ScoreController>
{
    private int score = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI HighscoreText;

    private void Start()
    {
        UpdateHighSCore();
        RefreshUI();
    }

    public void IncreaseScore(int increment)
    {
        score += increment;
        RefreshUI();
    }

    private void RefreshUI()
    {
        scoreText.text = "Score : " + score;
        Debug.Log("Score value:" + score);
        CheckHighScore(score);
    }

    public void CheckHighScore(int score)
    {
        if(PlayerPrefs.GetInt("HighScore", 0) < score)
        {
            PlayerPrefs.SetInt("Highscore", score);
        }
    }

    public void UpdateHighSCore()
    {
        HighscoreText.text = $"HighScore: {PlayerPrefs.GetInt("HighScore")}";
    }
}
