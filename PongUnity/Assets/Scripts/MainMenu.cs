using UnityEngine;
using UnityEngine.UI; // allows us to get methods and variables for button objects and other UI elements
using UnityEngine.SceneManagement; // allloows us to navigate from scene to scene (ie main menu to game)

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

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGameWithZeroPlayers()
    {
        PlayerPrefs.SetInt("GameMode", 0); // calling this will save a value of 0 to the key gamemode on local device. easy way to save simple data on diff consoles

        SceneManager.LoadScene(1);

    }
    void StartGameWithOnePlayer()
    {
        PlayerPrefs.SetInt("GameMode", 1); // setting game mode to 1 (for player vs bot)
        SceneManager.LoadScene(1); // we are still loading gameplay scene
    }
    void StartGameWithTwoPlayers()
    {
        PlayerPrefs.SetInt("GameMode", 2); // setting game mode to 2 (for two human players)
        SceneManager.LoadScene(1);
    }

}
