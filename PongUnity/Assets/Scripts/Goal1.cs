using UnityEngine;

public class Goal1 : MonoBehaviour
{
    public bool isPlayer1Goal;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.GetComponent < Ball>())
        {
            ScoreManager.Instance.GivePoint(isPlayer1Goal);
            Destroy(collision.gameObject);
        }
    }
}
