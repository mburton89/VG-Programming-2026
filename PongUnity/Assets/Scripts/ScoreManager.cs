using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    int p1Score;
    int p2Score;
    public int maxScore;
    public string p1WinMessage;
    public string p2WinMessage;
    public TextMeshProUGUI p1ScoreText;
    public TextMeshProUGUI p2ScoreText;
    public TextMeshProUGUI endGameText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
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
        }
        else
        {
            p2Score++;
        }
        CheckScoreAndUpdateScoreboard();
    }
    public void CheckScoreAndUpdateScoreboard()
    {
        if (p1Score >= maxScore || p2Score >= maxScore)
        {
            if (p1Score > p2Score)
            HandleWin(true);
            else HandleWin(false);
        }
        else
        {
            BallSpawner.instance.SpawnBall();
        }
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
