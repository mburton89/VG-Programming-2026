using Unity.VisualScripting.Antlr3.Runtime;
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
        else
        {
            FollowBall();           //if there is an active ball (not null) then follow it
        }
    }

    void LookForBall()
    { 
        activeBall = FindFirstObjectByType<Ball>();     //powerful but expensive method, looks through items in hierachy until finds something with that component
    }

    void FollowBall()
    {
        if (activeBall.transform.position.y < paddleToControl.transform.position.y)         //check position of ball to see if need to move up or down
        {
            paddleToControl.MoveDown();
        }
        else if (activeBall.transform.position.y > paddleToControl.transform.position.y)
        {
            paddleToControl.MoveUp();
        }
    }

    bool BallisApproaching()
    {
        return true;
    }
}
