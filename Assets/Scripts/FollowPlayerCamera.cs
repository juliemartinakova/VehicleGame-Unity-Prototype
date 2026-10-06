using UnityEngine;

public class FollowPlayerCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 cameraOffset = new Vector3(0, 5.5f, -7);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + cameraOffset;
    }
}
