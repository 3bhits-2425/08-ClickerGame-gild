using UnityEngine;
using TMPro;

public class ScoreManagerTMP : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;

    public void IncreaseScore()
    {
        score++;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.Save();
    }

    public void Reload()
    {
        score = PlayerPrefs.GetInt("score", 0);
        UpdateScoreText();
    }
}
