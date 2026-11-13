using Unity.Properties;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;

public class PaddleAI : MonoBehaviour
{
    public Paddle paddleToControl;
    public Ball activeBall;
    public float ballDistance;

    //right now our paddle bot is too good. It follows the ball to precisely so that the ball
    //always hit the very center. Thats no fun bc then there is no slope to the hit
    //lets add a distance buffer so that it hits z units away from the center. k?!

    public float distanceBuffer; // We will use this in out FollowBall() calculation

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
        if (activeBall.transform.position.y < paddleToControl.transform.position.y - distanceBuffer && paddleToControl.transform.position.y - distanceBuffer > paddleToControl.minYPosition)
        {
            paddleToControl.MoveDown();
        }
        else if (activeBall.transform.position.y > paddleToControl.transform.position.y + distanceBuffer && paddleToControl.transform.position.y + distanceBuffer < paddleToControl.maxYPosition)
        {
            paddleToControl.MoveUp();
        }
    }

    bool BallIsApproaching()
    {
        //Right now we are returning 'true' just as a placeholder. Thats why the ai bot's baddle ALWAYS follows the ball

        //two new floats to store the cistance between ball and paddle

        //before we 
        float previousDistanceBetweenBallAndPaddle = Mathf.Abs(activeBall.previouseXPosition - paddleToControl.transform.position.x);
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
