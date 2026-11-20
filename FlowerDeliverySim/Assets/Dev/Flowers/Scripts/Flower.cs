using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;

public class Flower : MonoBehaviour
{
    
    //We will have different types of flowers in the boquet and they will all have different health and point values
    public enum FlowerType
    {
        Rose,
        Tulip,
        Lily
    }

    public FlowerType flowerType;
    public float flowerCurrentHealth = 100;
    float flowerMaxHealth;
    public float degradationRate = 0;
    public float finalScore;
    public int pointValue;
    public float fallDamage;
    public bool isHeld;
    public Image healthBarFill;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        switch(flowerType)
        {
            case FlowerType.Rose:
                pointValue = 20;
                break;

            case FlowerType.Tulip:
                pointValue = 50;
                break;

            case FlowerType.Lily:
                pointValue = 100;
                break;
        }

        flowerMaxHealth = flowerCurrentHealth;
    }

    public float FinalPoints()
    {
        float healthPercentage = flowerCurrentHealth / 100;
        finalScore = Mathf.Round(pointValue * healthPercentage);
        ScoreManager.Instance.UpdateScore((int)finalScore);
        return finalScore;
    }
    void TakeDamage(float damage)
    {
        flowerCurrentHealth -= damage;
        Debug.Log("Flower has taken damage: " + damage);
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            TakeDamage(20);
        }
        else if (collision.gameObject.CompareTag("Flower"))
        {
            TakeDamage(2);
        }
        else if (collision.gameObject.CompareTag("Customer"))
        {
            FinalPoints();
            Debug.Log("Final Score:" + finalScore);
        }
    }
    void ToggleIsHeld()
    {
        if (isHeld)
        {
            //switch isHeld to false
            isHeld = false;

            //turn on gravity in rigidBody
            rb.useGravity = true;
            rb.constraints = RigidbodyConstraints.None;
            rb.constraints = RigidbodyConstraints.None;
        }
        else 
        {
            //switch isHeld to true
            isHeld = true;

            //set nice position and rotation
            transform.rotation = Quaternion.identity;
            transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);

            //turn off gravity in rigidBody
            rb.constraints = RigidbodyConstraints.FreezePosition;
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            rb.useGravity = false;
        }

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            degradationRate += .01f;
            Debug.Log("Degradation Rate: " + degradationRate);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            ToggleIsHeld();
        }

        flowerCurrentHealth -= degradationRate * Time.deltaTime;

        if (flowerCurrentHealth < 0)
        {
            Debug.Log("Flower has died");
            //Deletes the flower when it has died
            Destroy(gameObject);
        }

        healthBarFill.fillAmount = flowerCurrentHealth / flowerMaxHealth;

        if (isHeld)
        {
            Bob();
        }
    }

    void Bob()
    { 
        //TODO make transform smooth move up and and down on Y axis over time
    }
}
