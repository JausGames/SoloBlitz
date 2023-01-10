using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float gameSpeed = 10f;
    public bool gameOver = false;

    private ScoringSystem scoringSystem;

    void Start()
    {
        scoringSystem = GetComponent<ScoringSystem>();
    }

    void Update()
    {
        if (!gameOver)
        {
            gameSpeed += Time.deltaTime;
        }
    }

    public void GameOver()
    {
        gameOver = true;
        scoringSystem.OnGameOver();
    }
}
