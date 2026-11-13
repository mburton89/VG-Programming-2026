using UnityEngine;

public class Ball : MonoBehaviour
{
    public float maxYPosition;
    public float maxXPosition;
    public float movementSpeed;
    public Vector3 direction;

    //two new floats to hold previous and current X position
    //we want other classes to be able to access this data but we dont want the game designer to be able to assign this in unity inspector
    //so we can add this modifier called [HideInInspector]

    [HideInInspector] public float previousXPosition;
    [HideInInspector] public float currentXPosition;
    
    //next lets assign these values in Update()

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBoundaries();

        previousXPosition = currentXPosition;
        currentXPosition = transform.position.x;
    }

    void CheckBoundaries()
    {
        if (transform.position.y > maxYPosition || transform.position.y < -maxYPosition)
        {
            //we've hit the top or the bottom!
            Vector3 bounceDirection = new Vector3(direction.x, -direction.y);
            GetHit(bounceDirection);
        }
    }

    public void GetHit(Vector3 newDirection)
    { 
        direction = newDirection;
    }

    void Move()
    {
        transform.position += direction * movementSpeed;
    }

}
