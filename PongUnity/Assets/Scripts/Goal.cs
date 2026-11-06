using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayerOneGoal;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Ball>())
        {
            ScoreManager.Instance.GivePoint(isPlayerOneGoal);
            Destroy(collision.gameObject);
        }
    }
}
