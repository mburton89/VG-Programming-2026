using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class PaddleAI : MonoBehaviour
{
    public Paddle paddleToControl;
    public Ball activeBall;
    public float ballDistance;

    //right now our paddle bot is too good. It follows ball so precisely so taht the ball 
    //always hits the very center. Thats no fun bec then there is no slope to the hit
    //lets add a distance buffer so that it hits the ball x units away from the center.

    public float distanceBuffer;    //We will use this in our FollowBall() calculation

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
            if (BallisApproaching())
            {
                FollowBall(); //if there is an active ball (not null) then follow it
            }         
        }
    }

    void LookForBall()
    { 
        activeBall = FindFirstObjectByType<Ball>();     //powerful but expensive method, looks through items in hierachy until finds something with that component
    }

    void FollowBall()
    {
        //adding or subtracting distance buffer so it will move up or down until the ball is KINDA close to center
        if (activeBall.transform.position.y < paddleToControl.transform.position.y - distanceBuffer)         //check position of ball to see if need to move up or down
        {
            paddleToControl.MoveDown();
        }
        else if (activeBall.transform.position.y > paddleToControl.transform.position.y + distanceBuffer)
        {
            paddleToControl.MoveUp();
        }
    }

    bool BallisApproaching()
    {
        //Right now we are returning 'true' just as a placeholder. That's why the AI bot's paddle always follows the ball
        
        //two new floats to store the distance between ball and paddle
        //before we determine the distance, we need to make the Ball.cs class have more data
        float previousDistanceBetweenBallandPaddle 
            = Mathf.Abs(activeBall.previousXPosition - paddleToControl.transform.position.x);    //abs cause dont care if -/+
        float currentDistanceBetweenBallandPaddle 
            = Mathf.Abs(activeBall.currentXPosition - paddleToControl.transform.position.x);

        if (currentDistanceBetweenBallandPaddle < previousDistanceBetweenBallandPaddle)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
