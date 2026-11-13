using UnityEngine;

public class PaddleAI : MonoBehaviour
{
    public Paddle paddleToControl;
    public Ball activeBall;
    public float ballDistance;

    //The paddle bot always hits the center as it is too good.
    //Adding a distance buffer so that it hits the ball x units away from the center.
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float distanceBuffer; // will be used in the FollowBall calculations
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
            if (BallIsApproaching())
            {
                FollowBall();
            }
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
        //two new floats to store the distance between ball and paddle
        float previousDistanceBetweenBallAndPaddle = Mathf.Abs(activeBall.previousXPosition - paddleToControl.transform.position.x);
        float currentDistanceBetweenBallAndPaddle = Mathf.Abs(activeBall.currentXPosition - paddleToControl.transform.position.x);

        if (currentDistanceBetweenBallAndPaddle < previousDistanceBetweenBallAndPaddle)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}
