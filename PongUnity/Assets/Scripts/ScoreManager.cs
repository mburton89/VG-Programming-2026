using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    private int playerOneScore;
    private int playerTwoScore;
    public int maximumScore;
    public TextMeshProUGUI playerOneScoreText;
    public TextMeshProUGUI playerTwoScoreText;
    public TextMeshProUGUI endGameText;

    public string playerOneWinMessage;
    public string playerTwoWinMessage;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    public void GivePoint(bool isPlayerOne)
    {
        if (isPlayerOne)
        {
            playerOneScore++;
        }
        else
        {
            playerTwoScore++;
        }
        UpdateScoreboard();
        CheckScore();
    }
    public void CheckScore()
    {
        if(playerOneScore >= maximumScore)
        {
            OnWin(true);
        }
        else if (playerTwoScore >= maximumScore)
        {
            OnWin(false);
        }
        else
        {
            //TODO
        }
    }
    public void UpdateScoreboard()
    {
        playerOneScoreText.SetText(playerOneScore.ToString());
        playerTwoScoreText.SetText(playerTwoScore.ToString());
    }
    public void OnWin(bool isPlayerOne)
    {
        if (isPlayerOne)
        {
            endGameText.SetText(playerOneWinMessage.ToString());
        }
        else
        {
            endGameText.SetText(playerTwoWinMessage.ToString());
        }
    }
}
