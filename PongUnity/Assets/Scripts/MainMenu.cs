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
        twoPlayerButton.onClick.AddListener (StartGameWithTwoPlayers);
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
