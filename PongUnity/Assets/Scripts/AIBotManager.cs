using UnityEngine;

public class AIBotManager : MonoBehaviour
{
    // we need to cache the data of the two ai bots in the scene so that we can enable/disable them based on game mode

    public PaddleAI aiBot1;
    public PaddleAI aiBot2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // we need to search for a playerpref key called gamemode and use its value to determine how many bots to enable

        // NOTE playerprefs is a simple way to store data in unity

        if(PlayerPrefs.GetInt("GameMode") == 0)
       {
            // aka bot vs bot
            aiBot1.enabled = true;
            aiBot2.enabled = true;
       }
        if(PlayerPrefs.GetInt("GameMode") == 1)
       {
            // aka player vs bot
            aiBot1.enabled = false;
            aiBot2.enabled = true;
       }
        if(PlayerPrefs.GetInt("GameMode") == 2)
       {  // aka player vs ploayer
            aiBot1.enabled = false;
            aiBot2.enabled = false;
       }
        else
       {
            // handle scenario where game mode isnt set to make sure this never happens
            Debug.LogWarning("GAME MODE NOT SET!");
       }
    }


}
