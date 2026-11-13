using UnityEngine;

public class PaddleAI : MonoBehaviour
{
    public Paddle paddleToControl;
    public bool isP1;
    public float ballDistance;
    private Ball activeBall;
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
        else
        {
            FollowBall();
        }
    }

    void LookForBall()
    {
        activeBall = Object.FindFirstObjectByType<Ball>();
    }

    void FollowBall()
    {
        float tempDistanceBuffer = distanceBuffer;
        if (!BallIsApproaching())
        {
            tempDistanceBuffer *= 4.5f;
        }
        if (paddleToControl.transform.position.y > activeBall.transform.position.y + tempDistanceBuffer)
        {
            paddleToControl.MoveDown();
        }
        else if (paddleToControl.transform.position.y < activeBall.transform.position.y - tempDistanceBuffer)
        {
            paddleToControl.MoveUp();
        }
    }

    bool BallIsApproaching()
    {
        if (ballDirection() != isP1)
        return true;
        else return false;
    }

    bool ballDirection()
    {
        if (activeBall.direction.x > 0.0f)
            return true;
        else return false;
    }
}
