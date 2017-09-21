using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineMazeMovement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public GameObject cameraObject;

    float vertical;
    float vertical2;

    float horizontal;
    float horizontal2;

    Vector3 movement;
    Rigidbody rb;
    Animator anim;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update ()
    {
        vertical = PlayerInput.vertical;
        vertical2 = PlayerInput.vertical2;
        horizontal = PlayerInput.horizontal;
        horizontal2 = PlayerInput.horizontal2;

        anim.SetFloat("Horizontal", horizontal);
        anim.SetFloat("Horizontal2", horizontal2);
        anim.SetFloat("Vertical", vertical);

        movement = new Vector3(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime);

        if (movement.Equals(Vector3.zero))
            anim.SetBool("IsIdle", true);
        else
            anim.SetBool("IsIdle", false);

        transform.Rotate(new Vector3(0, horizontal2 * rotationSpeed * Time.deltaTime,0));
        cameraObject.transform.Rotate(new Vector3(-vertical2 * rotationSpeed * Time.deltaTime, 0, 0));

        movement = transform.TransformDirection(movement);
        rb.velocity = movement;
    }
}
