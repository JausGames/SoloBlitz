using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public Text scoreText;
    public Text finalScoreText;
    public GameObject gameOverPanel;

    private float score;
    private int finalScore;
    private bool gameOver = false;

    void Start()
    {
        score = 0;
        gameOverPanel.SetActive(false);
    }

    void Update()
    {
        if (!gameOver)
        {
            score += Time.deltaTime;
            scoreText.text = "Score: " + (int)score;
        }
    }

    public void OnGameOver()
    {
        gameOver = true;
        finalScore = (int)score;
        finalScoreText.text = "Score: " + finalScore;
        gameOverPanel.SetActive(true);
    }
}
