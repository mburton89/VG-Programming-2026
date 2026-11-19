using UnityEngine;
using UnityEngine.UI; //This allows us to get methods and variables for Button objects and other UI elements
using UnityEngine.SceneManagement; //This us allow us to navigate from scene to scene (ie: from the Main menu to the Gameplay Scene)

public class MainMenu : MonoBehaviour
{
    public Button zeroPlayersButton;
    public Button onePlayerButton;
    public Button twoPlayersButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Make sure...
        //zero.............................................Zero
        zeroPlayersButton.onClick.AddListener(StartGameWithZeroPlayers);

        //one............................................One
        onePlayerButton.onClick.AddListener(StartGameWithOnePlayer);

        //two.............................................Two
        twoPlayersButton.onClick.AddListener(StartGameWithTwoPlayers);
    }

    void StartGameWithZeroPlayers()
    {
        PlayerPrefs.SetInt("GameMode", 0); //Calling this will save a value of 0 to the 'Key' "GameMode" on your local device
        //this is an easy way to save simple data on iOS, Android, PC, Console, etc

        SceneManager.LoadScene(1);
    }

    void StartGameWithOnePlayer()
    {
        PlayerPrefs.SetInt("GameMode", 1); //Setting game mode to 1 (for one player vs bot)
        SceneManager.LoadScene(1); // we are still going to load the gameplay scene
    }

    void StartGameWithTwoPlayers()
    {
        PlayerPrefs.SetInt("GameMode", 2); //Setting game mode to 2 (for two humans vs each other)
        SceneManager.LoadScene(1); // we are still going to load the gameplay scene
    }
}
