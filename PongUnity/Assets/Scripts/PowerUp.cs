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
        switch (type)
        {
            case PowerUpType.speedIncrease:
                Debug.Log("Speed Increase");
                break;
            case PowerUpType.paddleShrink:
                Debug.Log("Paddle Shrink");
                break;
            case PowerUpType.multiBall:
                Debug.Log("Multiple Balls");
                break;
        }

        //this switch case above would complete the same tasks as the if statements below, but switch case is a bit more performat

        //if (type == PowerUpType.speedIncrease)
        //{
        //    Debug.Log("Speed Increase");
        //}
        //else if (type == PowerUpType.paddleShrink)
        //{
        //    Debug.Log("Paddle Shrink");
        //}
        //else if (type == PowerUpType.multiBall)
        //{
        //    Debug.Log("Multiple Balls");
        //}
    }
}
