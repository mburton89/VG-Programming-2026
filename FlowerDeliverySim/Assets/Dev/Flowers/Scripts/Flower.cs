using UnityEngine;

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
    public int flowerHealth = 100;
    public int degradationRate = 0;
    public int pointValue;
    public int fallDamage;
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
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            degradationRate++;
            Debug.Log("Degradation Rate:" + degradationRate);
        }
    } 
}
