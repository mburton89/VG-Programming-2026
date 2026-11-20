using System;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float mSpeed;
    public float mAcceleration;
    
    float leftOrRight;
    float upOrDown;

    float xVelocity;
    float zVelocity;

    float xDirection;
    float zDirection;

    float yRotation;

    public Vector3 velocity;

    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode upKey;
    public KeyCode downKey;

    public Rigidbody playerRigidBody;

    //public Customer activeCustomer;

    public void Update()
    {
        if (Input.GetKey(upKey))
        {
            upOrDown = 1;
        }
        else if (Input.GetKey(downKey))
        {
            upOrDown = -1;
        }
        else
        {
            upOrDown= 0;
        }

        if (Input.GetKey(leftKey))
        {
            leftOrRight = -1;
        }
        else if (Input.GetKey(rightKey))
        {
            leftOrRight = 1;
        }
        else
        {
            leftOrRight= 0;
        }
        MoveAndSlide();

    }

    public void MoveAndSlide()
    {
        // get the direction the player is currently moving in
        if (xVelocity > 0)
        {
            xDirection = 1;
        }
        else if (xVelocity < 0)
        {
            xDirection = -1;
        }
        else
        { 
            xDirection = 0; 
        }

        if (zVelocity > 0)
        {
            zDirection = 1;
        }
        else if (zVelocity < 0)
        {
            zDirection = -1;
        }
        else
        { 
            zDirection = 0; 
        }

        // compair that to the directions the player is trying to move it
        if ( leftOrRight == xDirection || xDirection == 0 )
        {
            // if the player is moving in the desired direction add acceleration and cap speed
            xVelocity += leftOrRight * mAcceleration;
            if (xVelocity > mSpeed)
            {
                xVelocity = mSpeed;
            }
            else if (xVelocity < -mSpeed)
            {
                xVelocity = -mSpeed;
            }
        }
        // if the player is moving in the wrong direction decrease speed
        else
        {
            if (xVelocity > 0)
            {
                xVelocity -= mAcceleration;
            }
            else if (xVelocity < 0)
            {
                xVelocity += mAcceleration;
            }
            //  if we're going slow set speed to zero
            if (math.abs(xVelocity) < mSpeed / 2)
            {
                xVelocity = 0;
            }
        }

        if ( upOrDown == zDirection || zDirection == 0 )
        {
            zVelocity += upOrDown * mAcceleration;
            if (zVelocity > mSpeed)
            {
                zVelocity = mSpeed;
            }
            else if (zVelocity < -mSpeed)
            {
                zVelocity = -mSpeed;
            }
        }
        else
        {
            if (zVelocity > 0)
            {
                zVelocity -= mAcceleration;
            }
            else if (zVelocity < 0)
            {
                zVelocity += mAcceleration;
            }
            //  if we're going slow set speed to zero
            if (math.abs(zVelocity) < mSpeed / 2)
            {
                zVelocity = 0;
            }
        }

        velocity = new Vector3(xVelocity, 0, zVelocity);
        playerRigidBody.position += velocity;

        float desiredRotation = GetRotation();
        if (desiredRotation != yRotation)
        {
            yRotation = Mathf.Lerp(yRotation, desiredRotation, 0.125f);
        }
        playerRigidBody.rotation = Quaternion.Euler(0f, yRotation, 0f);
    }

    public float GetRotation ()
    {
        float Rotation;
        float radians = MathF.Atan2(zDirection, xDirection);
        Rotation = radians * (180f / MathF.PI);
        return Rotation;
    }

    public void MakeDelivery()
    {

    }
}
