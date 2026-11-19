using UnityEngine;

public class PaddleAI : MonoBehaviour
{
    public Paddle paddleToControl;
    public Ball activeBall;
    public float ballDistance;

    //right now our paddle bot is too good. It follows the ball so precisely so that the ball
    //always hits the very center. Thats no fun bc then there is no slope to the hit
    //lets add a distance buffer so that it hits the ball x units away from the center. k?!

    public float distanceBuffer; // We will use this in our FollowBall() calculation


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
        //adding or subracting disance buffer so it will move up or down until the ball is KINDA close to center
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
        //Right now we are returning 'true' just as a placeholder. Thats why the ai bot's baddle ALWAYS follows the ball

        //two new floats to store the distance between ball and paddle

        //before we determine the distance, we need to make the Ball.cs class have more data
        float previousDistanceBetweenBallAndPaddle
            = Mathf.Abs(activeBall.previousXPosition - paddleToControl.transform.position.x);

        float currentDistanceBetweenBallAndPaddle
            = Mathf.Abs(activeBall.currentXPosition - paddleToControl.transform.position.x);

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
