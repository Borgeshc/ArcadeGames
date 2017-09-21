using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineMazeMovement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public GameObject cameraObject;

    Vector3 movement;
    Rigidbody rb;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        rb = GetComponent<Rigidbody>();
    }

    void Update ()
    {
        transform.Rotate(new Vector3(0, PlayerInput.horizontal2 * rotationSpeed * Time.deltaTime,0));
        cameraObject.transform.Rotate(new Vector3(-PlayerInput.vertical2 * rotationSpeed * Time.deltaTime, 0, 0));

        movement = new Vector3(PlayerInput.horizontal * speed * Time.deltaTime, 0, PlayerInput.vertical * speed * Time.deltaTime);
        movement = transform.TransformDirection(movement);
        rb.velocity = movement;
    }
}
