using UnityEngine;

public class PaddleAI : MonoBehaviour
{
    public Paddle paddleToControl;
    public Ball activeBall;
    public float ballDistance;

    public float distanceBuffer;

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
        else if (BallIsApproaching())
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
        if (activeBall.transform.position.y < paddleToControl.transform.position.y - distanceBuffer)
        {
            paddleToControl.MoveDown();
        }
        else if (activeBall.transform.position.y > paddleToControl.transform.position.y + distanceBuffer)
        {
            paddleToControl.MoveUp();
        }
    }

    bool BallIsApproaching()
    {
        float previousBallPaddleDistance = Mathf.Abs(activeBall.previousXPosition - paddleToControl.transform.position.x);
        float currentBallPaddleDistance = Mathf.Abs(activeBall.currentXPosition - paddleToControl.transform.position.x);
        return currentBallPaddleDistance < previousBallPaddleDistance;
    }
}
