using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;
using UnityEngine.VR;



public class kaydirma : MonoBehaviour
{
    //public GameObject gameObject;
    /*public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }*/

    float currentSpeed = 0.0F;
    public float maxSpeed = 100000.0F;
    public float acceleration = 100.15F;
    private CharacterController controller;
    void Update()
    {

        CharacterController controller = GetComponent<CharacterController>();
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        if (OVRInput.GetDown(OVRInput.Button.DpadUp))
        {
            Debug.Log("ads");
            currentSpeed += acceleration;
            currentSpeed = Mathf.Clamp(currentSpeed, 0.0F, maxSpeed);
            controller.SimpleMove(forward * currentSpeed);
        }
        if (OVRInput.GetDown(OVRInput.Button.DpadDown))
        {
            Debug.Log("asa");
            currentSpeed += acceleration;
            currentSpeed = Mathf.Clamp(currentSpeed, 0.0F, maxSpeed);
            controller.SimpleMove(-forward * currentSpeed);
        }
        //OVRInput.Get(OVRInput.Button.One) 

    }


}

