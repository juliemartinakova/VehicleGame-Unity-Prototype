using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour {

    public float speed = 25.0f; // Vehicle's speed in meters per second; 1m/s => 3.6km/h
    public float traverseSpeed = 100.0f; // Vehicle's traverse speed in °/s

    public InputAction steerAction;
    private Vector2 steerInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        steerAction.Enable();
    }

    // Update is called once per frame
    void Update(){
        steerInput = steerAction.ReadValue<Vector2>();

        transform.Translate(Vector3.forward * Time.deltaTime * speed * steerInput.y); // Gas/Reverse-Brake control
        transform.Rotate(Vector3.up * Time.deltaTime * traverseSpeed * steerInput.x); // Steering control
    }
}