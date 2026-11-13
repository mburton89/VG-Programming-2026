using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button zeroPlayersButton;
    public Button onePlayerButton;
    public Button twoPlayersButton;
    void Start()
    {
        zeroPlayersButton.onClick.AddListener(StartGameWithZeroPlayers);
        onePlayerButton.onClick.AddListener(StartGameWithOnePlayer);
        twoPlayersButton.onClick.AddListener(StartGameWithTwoPlayers);
    }

    void Update()
    {
        
    }
    void StartGameWithZeroPlayers()
    {
        PlayerPrefs.SetInt("GameMode", 0);
        SceneManager.LoadScene(1);
    }
    void StartGameWithOnePlayer()
    {
        PlayerPrefs.SetInt("GameMode", 1);
        SceneManager.LoadScene(1);
    }
    void StartGameWithTwoPlayers()
    {
        PlayerPrefs.SetInt("GameMode", 2);
        SceneManager.LoadScene(1);
    }
}
