using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.LowLevelPhysics;

public class TrainMovement : MonoBehaviour
{
    public Transform startDestination;
    public Transform endDestination;
    public List<Transform> Stops;
    //public Vector3 direction;
    public float movementSpeed;
    public float brakingSpeed;

    private int currentStopId;
    Rigidbody trainRB;

    private void Start()
    {
        startDestination = transform;
    }

    private void FixedUpdate()
    {
        if (startDestination != Stops[currentStopId])
        {
            float choochoo = movementSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Stops[currentStopId].position, choochoo);

            if (transform.position == Stops[currentStopId].position)
            {
                //Add pause before moving again here
                currentStopId += 1;
            }
        }
    }
}
