using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public bool sizeDecrease;
    public Paddle p1Paddle;
    public Paddle p2Paddle;

    int p1Score;
    int p2Score;
    public int maxScore;
    public TextMeshProUGUI p1ScoreText;
    public TextMeshProUGUI p2ScoreText;
    public TextMeshProUGUI endGameText;

    public string p1WinMessage;
    public string p2WinMessage;

    // like start but runs one second before start
    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GivePoint(bool isPlayer1)
    {
        if (isPlayer1)
        {
            p1Score++;

            if (sizeDecrease)
            {
                p1Paddle.transform.localScale -= new Vector3(0, 0.1f);
            }
        }
        else
        {
            p2Score++;

            if (sizeDecrease)
            {
                p2Paddle.transform.localScale -= new Vector3(0, 0.1f);
            }
        }

        UpdateScoreboard();
        CheckScore();
    }

    public void CheckScore()
    {
        if (p1Score >= maxScore)
        {
            HandleWin(true);
        }
        else if (p2Score >= maxScore)
        {
            HandleWin(false);
        }
        else
        {
            BallSpawner.Instance.SpawnBall();       //so hey, theres this one thing (instance) that has a function i want
        }
    }

    public void UpdateScoreboard()
    {
        p1ScoreText.SetText(p1Score.ToString());
        p2ScoreText.SetText(p2Score.ToString());
    }

    public void HandleWin(bool player1Won)
    {
        if (player1Won)
        {
            endGameText.SetText(p1WinMessage);
        }
        else
        { 
            endGameText.SetText(p2WinMessage);
        }
    }
}
