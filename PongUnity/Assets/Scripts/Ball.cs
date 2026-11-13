using UnityEngine;

public class Ball : MonoBehaviour
{
    public float maxYPosition;
    public float maxXPosition;
    public float movementSpeed;
    public Vector3 direction;

    public bool useSpeedIncrease;
    int timesHit = 10;

    //two new floats to hold previouse and current X Position
    //we want other classes to be able to access this data
    //but we DONT wnat the game designer to be able  to asign these in UNity inspector
    //...so we can add this modifier called [HideInInspecot]
    [HideInInspector] public float previouseXPosition;
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

        previouseXPosition = currentXPosition;
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
        timesHit++;
    }

    void Move()
    {
        if (useSpeedIncrease)
        {
            transform.position += direction * movementSpeed * (timesHit / 10);
        }
        else
        {
            transform.position += direction * movementSpeed;
        }
    }

}
