using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float maxYPosition;
    public float minYPosition;
    public int xHitDirection;
    public float verticalMovementSpeed;

    public KeyCode upKey;
    public KeyCode downKey;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey))
        {
            MoveUp();
        }
        else if (Input.GetKey(downKey))
        {
            MoveDown();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //we've collided with something

        if (collision.gameObject.TryGetComponent(out Ball ball))
        {
            //its the BALL that we've collided with

            float yHitDirection = collision.transform.position.y - transform.position.y;

            Vector3 newHitDirection = new Vector3(xHitDirection, yHitDirection);

            ball.GetHit(newHitDirection);
        }
    }

    
    public void MoveUp()
    {
        if (transform.position.y < maxYPosition)
        transform.position += Vector3.up * verticalMovementSpeed;
    }

    public void MoveDown()
    {
        if (transform.position.y > minYPosition)
        transform.position += Vector3.down * verticalMovementSpeed;
    }

    public void HitBall()
    { 
    
    }
}
