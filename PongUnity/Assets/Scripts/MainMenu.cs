using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button zeroPlayerButton;
    public Button onePlayerButton;
    public Button twoPlayerButton;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        zeroPlayerButton.onClick.AddListener(StartGameWithZeroPlayers);
        onePlayerButton.onClick.AddListener(StartGameWithOnePlayer);
        twoPlayerButton.onClick.AddListener(StartGameWithTwoPlayers);

    }

    void StartGameWithZeroPlayers()
    {
        //Saves a value of 0 to the Key GamMode meaning the game is bot vs bot
        PlayerPrefs.SetInt("GameMode", 0);
        SceneManager.LoadScene(1);
    }

    void StartGameWithOnePlayer()
    {
        //Sets GameMode to 1 for one player vs a bot
        PlayerPrefs.SetInt("GameMode", 1);
        SceneManager.LoadScene(1);
    }

    void StartGameWithTwoPlayers()
    {
        PlayerPrefs.SetInt("GameMode", 2);
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
