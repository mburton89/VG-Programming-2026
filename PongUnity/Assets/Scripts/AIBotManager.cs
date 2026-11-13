using UnityEngine;

public class AIBotManager : MonoBehaviour
{
    public PaddleAI Bot1;
    public PaddleAI Bot2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (PlayerPrefs.GetInt("GameMode"))
        {
            default:
                Debug.LogWarning("Not Set!");
                break;
            case 0:
                Bot1.enabled = true;
                Bot2.enabled = true;
                break;
            case 1:
                Bot1.enabled = false;
                Bot2.enabled = true;
                break;
            case 2:
                Bot1.enabled = false;
                Bot2.enabled = false;
                break;
        }
    }
}
