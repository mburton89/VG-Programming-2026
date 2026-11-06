using System.Collections;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public static BallSpawner Instance;
    public GameObject ballPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        SpawnBall();
    }

    public void SpawnBall()
    {
        StartCoroutine(DelaySpawnBall());
    }
    public IEnumerator DelaySpawnBall()
    {
        yield return new WaitForSeconds(2);

        GameObject newBall = Instantiate(ballPrefab);

        int randX = Random.Range(0,2) * 2 - 1;
        float randY = Random.Range(-0.5f, 0.5f);

        newBall.GetComponent<Ball>().direction = new Vector3(randX, randY).normalized;

    }
}
