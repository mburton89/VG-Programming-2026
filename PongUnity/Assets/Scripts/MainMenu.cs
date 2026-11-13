using UnityEngine;
using UnityEngine.UI; //This allows us to 
using UnityEngine.SceneManagement; //This us allow us to navigate from scene to scene (ie: from the Main menu to the Gameplay Scene)

public class MainMenu : MonoBehaviour
{
    public Button onePlayerButton;
    public Button twoPlayerButton;
    public Button zeroPlayerButton;

    void Start()
    {
        zeroPlayerButton.onClick.AddListener(StartGameWithZeroPlayers);
        onePlayerButton.onClick.AddListener(StartGameWithOnePlayer);
        twoPlayerButton.onClick.AddListener(StartGameWithTwoPlayers);
    }

    void StartGameWithZeroPlayers()
    {
        PlayerPrefs.SetInt("GameMode", 0); //Calling this will save a value of 0 to he 'key' "GameMode" on your local device
        //this is an easy way to save simple data on ios, Android, PC, Condole, etc

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
