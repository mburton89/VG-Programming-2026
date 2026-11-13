using System.Linq.Expressions;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public enum PowerUpType
    {
        speedIncrease,
        paddleShrink,
        multiBall
    }

    public PowerUpType type;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch(type)
        {
            case PowerUpType.speedIncrease:
                Debug.Log("Speed Increase");
                break;
            case PowerUpType.paddleShrink:
                Debug.Log("Paddle Shrink");
                break;
            case PowerUpType.multiBall:
                Debug.Log("multiBall");
                break;
        }


    }
}
