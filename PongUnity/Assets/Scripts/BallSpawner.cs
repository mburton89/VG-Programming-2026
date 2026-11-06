using System.Collections;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public static BallSpawner Instance;

    public GameObject ballPrefab;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnBall();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    SpawnBall();
        //}
    }

    public void SpawnBall()
    {
        StartCoroutine(DelaySpawnBall());
    }

    private IEnumerator DelaySpawnBall()
    {
        Debug.Log("About to spawn ball -- waiting for X seconds");
        yield return new WaitForSeconds(2);
        Debug.Log("Ball Spawned");

        GameObject newBall = Instantiate(ballPrefab);

        int randX = Random.Range(0, 2) * 2 - 1;
        float randY = Random.Range(-0.5f, 0.5f);

        newBall.GetComponent<Ball>().direction = new Vector3(randX, randY).normalized;

        //normalized math examples
        //(0.1, 0.5) == (0.2, 1.0)
        //(0.5, 0.5) == (1.0, 1.0)
        //(0.2, 0.4) == (0.5, 1.0)
    }
}
