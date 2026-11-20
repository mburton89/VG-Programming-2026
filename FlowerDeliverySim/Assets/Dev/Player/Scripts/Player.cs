using UnityEngine;

public class Player : MonoBehaviour
{
    public float mSpeed;
    public float mAcceleration;
    public float leftOrRight;
    public float upOrDown;

    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode upKey;
    public KeyCode downKey;

    public Customer activeCustomer;

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
            leftOrRight = 1;
        }
        else if (Input.GetKey(rightKey))
        {
            leftOrRight = -1;
        }
        else
        {
            leftOrRight= 0;
        }
        MoveAndSlide();

    }

    public void MoveAndSlide()
    {

    }

    public void MakeDelivery()
    {

    }
}
