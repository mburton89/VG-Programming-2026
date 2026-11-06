using System.Collections;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public static BallSpawner instance;

    public GameObject ballPrefab;

    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnBall();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        SpawnBall();
    //    }
    //}

    public void SpawnBall()
    {
        StartCoroutine(DelaySpawnBall());
    }

    private IEnumerator DelaySpawnBall()
    {
        Debug.Log("About to spawn ball -- waiting for X seconds");
        yield return new WaitForSeconds(0.5f);
        Debug.Log("Ball spawned");

        GameObject newBall = Instantiate(ballPrefab);

        int randXPolar = Random.Range(0, 2) * 2 - 1;
        float randX = Random.Range(0.15f, 1.0f);
        float randY = Random.Range(-1.0f, 1.0f);

        newBall.GetComponent<Ball>().direction = new Vector3(randX * randXPolar, randY).normalized;

        //normalized math examples
        //(0.1, 0.5) ==> (0.2, 1.0)
        //(0.5, 0.5) ==> (1.0, 1.0)
        //(0.2, 0.4) ==> (0.5, 1.0)

    }
}
