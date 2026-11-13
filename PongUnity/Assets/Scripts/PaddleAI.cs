using UnityEngine;

public class PaddleAI : MonoBehaviour
{

    public Paddle paddleToControl;
    public Ball activeBall;
    public float ballDistance;
    public float distanceBuffer;
    
    // we will use this in our followball calculation

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
        else
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
        // adding or subtracting distance buffer so it will move up or down until its kinda close to center
        if(activeBall.transform.position.y < paddleToControl.transform.position.y - distanceBuffer)
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
        // right now we are returning true just as a placeholder. thats why the ai bots paddle always follows the ball

        // two new floats to store the distance between ball and paddle

        float previousDistanceBetweenBallAndPaddle = Mathf.Abs(activeBall.previousXPosition - paddleToControl.transform.position.x);
        float currentDistanceBetweenBallAndPaddle = Mathf.Abs(activeBall.currentXPosition - paddleToControl.transform.position.x);

        if(currentDistanceBetweenBallAndPaddle < previousDistanceBetweenBallAndPaddle)
        {
            return true;
        }
        else
        {  return false; }
    }

}
