using UnityEngine;

public class AIBotManager : MonoBehaviour
{
    public PaddleAI aiBot1;
    public PaddleAI aiBot2;
    void Start()
    {
        if(PlayerPrefs.GetInt("GameMode") == 0)
        {
            aiBot1.enabled = true;
            aiBot2.enabled = true;
        }
        if (PlayerPrefs.GetInt("GameMode") == 1)
        {
            aiBot1.enabled = false;
            aiBot2.enabled = true;
        }
        if (PlayerPrefs.GetInt("GameMode") == 2)
        {
            aiBot1.enabled = false;
            aiBot2.enabled = false;
        }
        else
        {
            Debug.LogError("Invalid GameMode value in PlayerPrefs: " + PlayerPrefs.GetInt("GameMode"));
        }
    }

    void Update()
    {
        
    }
}
