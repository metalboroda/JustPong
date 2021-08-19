using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPaddle;
    public int PlayerScore { get; private set; }
    public Text playerScoreText;

    public Paddle computerPaddle;
    public int ComputerScore { get; private set; }
    public Text computerScoreText;

    private void Start()
    {
        NewGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            NewGame();
        }
    }

    public void NewGame()
    {
        SetPlayerScore(0);
        SetComputerScore(0);
        StartRound();
    }

    public void StartRound()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    public void PlayerScores()
    {
        SetPlayerScore(this.PlayerScore + 1);
        StartRound();
    }

    public void ComputerScores()
    {
        SetComputerScore(this.ComputerScore + 1);
        StartRound();
    }

    private void SetPlayerScore(int score)
    {
        this.PlayerScore = score;
        this.playerScoreText.text = score.ToString();
    }

    private void SetComputerScore(int score)
    {
        this.ComputerScore = score;
        this.computerScoreText.text = score.ToString();
    }
}