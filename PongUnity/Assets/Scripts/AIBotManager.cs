using UnityEngine;

public class AIBotManager : MonoBehaviour
{
    //we need to cache the data of the two existing AI Bots in the scene so
    //that we can enable/disable them based on the game mode
    public PaddleAI aiBot1;
    public PaddleAI aiBot2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //we need to search for a PlayerPref 'Key' called "GameMode" and use its value
        //to determine how many bots to enable

        //NOTE PlayerPrefs is a simple way to store data in Unity

        if (PlayerPrefs.GetInt("GameMode") == 0)
        {
            //Zero players mode / AKA bot vs bot
            aiBot1.enabled = true;
            aiBot2.enabled = true;
        }
        else if (PlayerPrefs.GetInt("GameMode") == 1)
        {
            //One player mode / AKA human vs bot
            aiBot1.enabled = false;
            aiBot2.enabled = true;
        }
        else if (PlayerPrefs.GetInt("GameMode") == 2)
        {
            //Two player mode / AKA human vs human
            aiBot1.enabled = false;
            aiBot2.enabled = false;
        }
        else
        {
            //Handle scenario where game mode isnt set to help make sure this never happens
            Debug.LogWarning("GAME MODE NOT SET!");
        }
    }

    //Delete Update method
}
