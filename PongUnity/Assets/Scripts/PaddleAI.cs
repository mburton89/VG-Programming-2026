using UnityEngine;

public class PaddleAI : MonoBehaviour
{
    public Paddle paddleToControl;
    public float ballDistance;
    private Ball activeBall;

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
        else if(BallIsApproaching())
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
        float Rand = Random.Range(-1.0f, 1.0f);
        if (paddleToControl.transform.position.y > activeBall.transform.position.y + Rand)
        {
            paddleToControl.MoveDown();
        }
        else if (paddleToControl.transform.position.y < activeBall.transform.position.y + Rand)
        {
            paddleToControl.MoveUp();
        }
    }

    bool BallIsApproaching()
    {
        return true;
    }
}
