using Unity.VisualScripting;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public float movementSpeed;
    public float maxDistance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCustomer();
    }

    public void MoveCustomer()
    {
       
        Vector3 newRotation = new Vector3(0, 1, 0);
        transform.Rotate(newRotation);
        transform.position += Vector3.forward * movementSpeed;

        //Vector3 movement = transform.position += Vector3.forward * movementSpeed;
        //movement = transform.rotation * movement;
        //Vector3 movement = transform.position * movementSpeed;
        // movement = transform.right * movementSpeed;

    }

    public void HandlePlayerCollision()
    {
        //OnCollisionEnter
    }
}
