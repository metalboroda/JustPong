using UnityEngine;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPaddle;
    public int PlayerScore { get; private set; }
    public Text playerScoreText;

    public Paddle secondPlayerPaddle;
    public int SecondPlayerScore { get; private set; }
    public Text secondPlayerScoreText;

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
        SetSecondPlayerScore(0);
        StartRound();
    }

    public void StartRound()
    {
        this.playerPaddle.ResetPosition();
        this.secondPlayerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    public void PlayerScores()
    {
        SetPlayerScore(this.PlayerScore + 1);
        StartRound();
    }

    public void SecondPlayerScores()
    {
        SetSecondPlayerScore(this.SecondPlayerScore + 1);
        StartRound();
    }

    private void SetPlayerScore(int score)
    {
        this.PlayerScore = score;
        this.playerScoreText.text = score.ToString();
    }

    private void SetSecondPlayerScore(int score)
    {
        this.SecondPlayerScore = score;
        this.secondPlayerScoreText.text = score.ToString();
    }
}