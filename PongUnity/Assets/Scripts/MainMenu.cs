using UnityEngine;
using UnityEngine.UI; //This allows us to get methods and variables for Button objects and other UI elements
using UnityEngine.SceneManagement; //This allows us to navigate from scene to scene (ie: from Main menu to the Gameplay Scene)

public class MainMenu : MonoBehaviour
{
    public Button zeroPlayersButton;
    public Button onePlayerButton;
    public Button twoPlayersButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Make sure...
        //zero.............................................zero
        zeroPlayersButton.onClick.AddListener(StartGameWithZeroPlayers);    //AddListener tells button to listen for an event on click
                                                                            //kinda just needed after onclick, weird
        //one..............................................one
        onePlayerButton.onClick.AddListener(StartGameWithOnePlayer);

        //two..............................................two
        twoPlayersButton.onClick.AddListener(StartGameWithTwoPlayers);
    }

    void StartGameWithZeroPlayers()
    {
        PlayerPrefs.SetInt("GameMode", 0); //Calling this will save a value of 0 to the 'Key' "GameMode" on your local device
        //this is an easy way to save simple data on iOS, Andriod, PC, Console, etc.
        //will remember and look for the gamemode thing and the 0 players set

        SceneManager.LoadScene(1);
        //File --> BuildProfiles --> Open Scene List --> Drag to change order of scenes so Menu is 0 and gameplay is 1
    }

    void StartGameWithOnePlayer()
    {
        PlayerPrefs.SetInt("GameMode", 1); //sets game mode to 1 for one player vs bot
        SceneManager.LoadScene(1);
    }

    void StartGameWithTwoPlayers()
    {
        PlayerPrefs.SetInt("GameMode", 2);
        SceneManager.LoadScene(1);
    }
}
