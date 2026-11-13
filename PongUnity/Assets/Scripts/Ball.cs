using UnityEngine;

public class Ball : MonoBehaviour
{
    public float maxYPosition;
    public float maxXPosition;
    public float movementSpeed;
    public Vector3 direction;

    public float speedToIncrease;
    public bool applySpeedIncrease; //WILL NEED TO TOGGLE THIS ON IN BALL PREFAB

    [HideInInspector] public float previousXPosition;
    [HideInInspector] public float currentXPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBoundaries();

        UpdateXPositions();
    }

    void UpdateXPositions()
    {
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

        if (applySpeedIncrease)
        { 
            movementSpeed += speedToIncrease;
        }
    }

    void Move()
    {
        transform.position += direction * movementSpeed;
    }

}
