using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button onePlayerButton;
    public Button twoPlayerButton;
    public Button noPlayerButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        noPlayerButton.onClick.AddListener(StartGameWithZeroPlayers);
        onePlayerButton.onClick.AddListener(StartGameWithOnePlayer);
        twoPlayerButton.onClick.AddListener(StartGameWithTwoPlayers);
    }

    // Update is called once per frame

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
