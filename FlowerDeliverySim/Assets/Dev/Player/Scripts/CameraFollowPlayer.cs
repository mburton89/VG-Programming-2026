using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform player;
    public Transform mainCamera;
    public float xOffset;
    public float zOffset;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.position = new Vector3(player.position.x + xOffset, mainCamera.position.y, player.position.z + zOffset);
    }


}
