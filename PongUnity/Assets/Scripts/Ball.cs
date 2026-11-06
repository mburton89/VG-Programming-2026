using UnityEngine;

public class Ball : MonoBehaviour
{
    public float maxYPosition;
    public float maxXPosition;
    public float movementSpeed;
    public bool increaseSpeed;
    public Vector3 direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBoundaries();
    }

    void CheckBoundaries()
    {
        if (transform.position.y > maxYPosition || transform.position.y < -maxYPosition)
        {
            Vector3 bounceDirection = new Vector3(direction.x, -direction.y);
            GetHit(bounceDirection);
        }
    }

    public void GetHit(Vector3 newDirection)
    {
        if (increaseSpeed)
        {
            movementSpeed += 0.01f;
        }
        direction = newDirection;
    }

    void Move()
    {
        transform.position += direction * movementSpeed;
    }

}
