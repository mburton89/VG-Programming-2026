using UnityEngine;
using System.Collections.Generic;

public class Powerup : MonoBehaviour
{
    public enum PowerupType
    {
        SpeedIncrease,
        PaddleShrink,
        MultiBall,
    }
    public PowerupType powerupType;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (powerupType)
        {
            case PowerupType.SpeedIncrease:
                break;
            case PowerupType.PaddleShrink:
                break;
            case PowerupType.MultiBall:
                break;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
