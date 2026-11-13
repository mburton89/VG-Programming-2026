using UnityEngine;

public class Powerup : MonoBehaviour
{
    public enum PowerupType
    {
        speedIncrease,
        paddleShrink,
        multiBall
    }

    public PowerupType type;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (type)
        {
            case PowerupType.speedIncrease:
                Debug.Log("Speed Increase Trigger");
                break;
            case PowerupType.paddleShrink:
                Debug.Log("Paddle Shrink");
                break;
            case PowerupType.multiBall:
                Debug.Log("Multi Ball - Jimmy Lightning");
                break;
        }
    }
}