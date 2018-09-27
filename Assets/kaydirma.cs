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
    public float maxSpeed = 1.0F;
    public float acceleration = 1.15F;
    public CharacterController controller;

    void Update()
    {

        CharacterController controller = GetComponent<CharacterController>();
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);
        //Karakteri ileri doğru ilerlet.
        if (OVRInput.GetDown(OVRInput.Button.DpadUp))
            
        {
            Debug.Log("Char moves forward");
            currentSpeed += acceleration;
            currentSpeed = Mathf.Clamp(currentSpeed, 0.0F, maxSpeed);
            controller.SimpleMove(forward * currentSpeed);
        }
        //Karakteri geriye doğru ilerlet.
        if (OVRInput.GetDown(OVRInput.Button.DpadDown))
        {
            Debug.Log("Char moves backward");
            currentSpeed += acceleration;
            currentSpeed = Mathf.Clamp(currentSpeed, 0.0F, maxSpeed);
            controller.SimpleMove(-forward * currentSpeed);

        }
        //Karakteri sağa doğru ilerlet
        if(OVRInput.Get(OVRInput.Button.Two))
        {
            Debug.Log("Char moves right");
            currentSpeed += acceleration;
            currentSpeed = Mathf.Clamp(currentSpeed, 0.0F, maxSpeed);
            controller.SimpleMove(right * currentSpeed);


           

        }

        //Karakteri Sola doğru hareket ilerlet.
        if (OVRInput.Get(OVRInput.Button.One))
        {
            Debug.Log("Char moves to");
            currentSpeed += acceleration;
            currentSpeed = Mathf.Clamp(currentSpeed, 0.0F, maxSpeed);
            controller.SimpleMove(-right * currentSpeed);




        }
        //OVRInput.Get(OVRInput.Button.One) 

    }


}

