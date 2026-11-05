using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBall();
        }
    }

    public void SpawnBall()
    {
        GameObject newBall = Instantiate(ballPrefab);

        float randX = Random.Range(-1.0f, 1.0f);
        float randY = Random.Range(-1.0f, 1.0f);

        newBall.GetComponent<Ball>().direction = new Vector3(randX, randY).normalized;

        //normalized math examples
        //(0.1, 0.5) ==> (0.2, 1.0)
        //(0.5, 0.5) ==> (1.0, 1.0)
        //(0.2, 0.4) ==> (0.5, 1.0)
    }
}
