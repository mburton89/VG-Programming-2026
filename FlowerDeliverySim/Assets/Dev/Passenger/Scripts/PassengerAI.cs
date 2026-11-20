using System.Collections;
using System.Runtime.ConstrainedExecution;
using UnityEditor.Hardware;
using UnityEngine;

public class PassengerAI : MonoBehaviour
{

    public float MovementSpeed;
    public float MovementDistance;
    public float MaxRadius;
    public float AveragePauseTime;
    public Vector3 StartingPoint;

    private Vector3 currentDirection;
    private Vector3 targetPos;
    private bool isNavigating = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetPos = GetTargetPos();
    }

    // Update is called once per frame
    void Update()
    {
        Navigate();
    }
    void Navigate()
    {
        if (!isNavigating)
        {
            return;
        }
        if (Vector3.Distance(transform.position, targetPos) > 0.1f)
        {
            Move(currentDirection);
        }
        else
        {
            StartCoroutine(PauseNavigation());
        }
    }
    Vector3 GetTargetPos()
    {
        var rotation = Quaternion.AngleAxis(Random.Range(-180,180),Vector3.up);
        currentDirection = rotation * transform.forward;
        return transform.position + currentDirection * MovementDistance;
    }
    bool IsWithinDistance(Vector3 targetPos)
    {
        return Vector3.Distance(targetPos, StartingPoint) < MaxRadius;
    }
    IEnumerator PauseNavigation()
    {
        isNavigating = false;
        yield return new WaitForSeconds(AveragePauseTime * Random.Range(0.75f,1.25f));
        isNavigating = true;
        do
        {
            targetPos = GetTargetPos();
        } while (!IsWithinDistance(targetPos));
    }
    void Move(Vector3 direction)
    {
        transform.position += direction * MovementSpeed;
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out PassengerAI/*replace with player soon*/ player))
        {

        }
        else if (collision.gameObject.TryGetComponent(out PassengerAI passenger))
        {

        }
    }
    void CollideWithPlayer()
    {
    
    }
    void CollideWithOtherPassenger()
    {

    }

}
