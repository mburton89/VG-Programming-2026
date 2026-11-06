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
        
    }
    void LookForBall()
    {
        activeBall = FindFirstObjectByType<Ball>();
    }
    void FollowBall()
    {

    }
    bool IsBallApproaching()
    {

    }
}
