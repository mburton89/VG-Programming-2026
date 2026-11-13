using UnityEngine;

public class AIBotManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public PaddleAI aiBot1;
    public PaddleAI aiBot2;
    void Start()
    {
        //NOTE PlayerPrefs is a simple way to store data in Unity

        if (PlayerPrefs.GetInt("GameMode") == 0)
        {
            //Zero players so its bot vs bot
            aiBot1.enabled = true;
            aiBot2.enabled = true;
        }

        else if (PlayerPrefs.GetInt("GameMode") == 1)
        {
            //One player vs a bot
            aiBot1.enabled = false;
            aiBot2.enabled = true;
        }

        else if (PlayerPrefs.GetInt("GameMode") == 2)
        {
            //Two players so its player vs player
            aiBot1.enabled = false;
            aiBot2.enabled = false;
        }

        else
        {
            Debug.LogWarning("GAME MODE NOT SET");
        }
    }
}
