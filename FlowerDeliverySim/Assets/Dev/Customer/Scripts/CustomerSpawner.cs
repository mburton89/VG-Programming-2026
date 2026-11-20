using System.Collections;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    public static CustomerSpawner Instance;
    public GameObject customerPrefab;

    //public int minCustomers;
    //public int maxCustomers;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnCustomer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCustomer()
    {
        StartCoroutine(DelayCustomerSpawn());
    }

    IEnumerator DelayCustomerSpawn()
    {
        yield return new WaitForSeconds(3);
        
        //int customerCount = Random.Range(minCustomers, maxCustomers + 1);
        GameObject newCustomer = Instantiate(customerPrefab);
       // newCustomer.GetComponent<Customer>();
       
    }
    

    private void OnDestroy()
    {
        SpawnCustomer();
    }
}
