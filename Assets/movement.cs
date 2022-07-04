using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class movement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 15f;
    public float gravity = -9.81f;
    public float jump = 5f;

    Vector3 velocity;

    public Transform fallstop;
    public float ground = 0.4f;
    public LayerMask groundMask;
    bool isG;

    void Update()
    {
        isG = Physics.CheckSphere(fallstop.position, ground, groundMask);

        if(isG && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(isG && Input.GetButtonDown("Jump"))
            {
                velocity.y = Mathf.Sqrt(jump * -2f * gravity);
            }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

}
