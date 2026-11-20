using UnityEngine;

public class PassengerAIBehavior : MonoBehaviour
{

    public int movementSpeed;
    public int maxMoveDistance;
    public Vector3 startingPoint;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
    }


    bool isWithinDIstance(GameObject gameObject)
    {
        return Vector3.Distance(gameObject.transform.position, startingPoint) < maxMoveDistance;
    }

    public void MoveForward()
    {
        transform.position += Vector3.forward * movementSpeed;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {

        }
        else if (collision.gameObject.TryGetComponent(out PassengerAI passenger))
        {

        }
    }
        void collideWithPlayer()
    {
    
    }
    void collideWithOtherPassenger()
    {

    }

}
