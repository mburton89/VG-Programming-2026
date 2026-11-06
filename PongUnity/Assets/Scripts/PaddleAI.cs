using UnityEngine;

public class PaddleAI : MonoBehaviour
{
    public Paddle paddleToControl;
    public Ball activeBall;
    public float ballDistance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activeBall == null)
        {
            LookForBall();
        }
        else //THE BALL IS FOUND!
        {
            FollowBall();
        }
    }

    void LookForBall()
    {
        activeBall = FindFirstObjectByType<Ball>();
    }

    void FollowBall()
    {
        if (activeBall.transform.position.y < paddleToControl.transform.position.y)
        {
            paddleToControl.MoveDown();
        }
        else if (activeBall.transform.position.y > paddleToControl.transform.position.y)
        {
            paddleToControl.MoveUp();
        }
    }

    bool BallIsApproaching()
    {
        return true;
    }
}
