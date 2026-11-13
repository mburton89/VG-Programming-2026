using UnityEngine;
using System.Collections.Generic;

public class Powerup : MonoBehaviour
{
    public enum Poweruptype
    {
        speedIncrease,
        paddleShrink,
        multiBall
    }

    public Poweruptype type;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (type)
        {
            case Poweruptype.speedIncrease:
                Debug.Log("Speed Increase");
                break;
            case Poweruptype.paddleShrink:
                Debug.Log("Paddle Shrink");
                break;
            case Poweruptype.multiBall:
                Debug.Log("MultiBall");
                break;
        }
    }
}
