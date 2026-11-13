using UnityEngine;

public class AIBotManager : MonoBehaviour
{
    public PaddleAI aiBot1;
    public PaddleAI aiBot2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.GetInt("GameMode") == 0)
        {
            aiBot1.enabled = true;
            aiBot2.enabled = true;
        }
        else if (PlayerPrefs.GetInt("GameMode") == 1)
        {
            aiBot1.enabled = false;
            aiBot2.enabled = true;
        }
        else if(PlayerPrefs.GetInt("GameMode") == 2)
        {
            aiBot1.enabled = false;
            aiBot2.enabled = false;
        }
        else
        {
            Debug.LogWarning("GAME MODE NOT SET!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
