using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    public Camera cam;
    public PlayerController playerController;
    
    private Vector3 velocity;
    private Vector3 rotation;
    private Vector3 cameraRotation;

    private bool isJumping;
    private float jumpForce;

    public Transform groundCheck;
    public float radius;
    public LayerMask collisionLayers;

    public bool isGrounded;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 _velocity)
    {
        velocity = _velocity;
    }

    public void Jump(bool _isJumping , float _jumpForce)
    {
        isJumping = _isJumping;
        jumpForce = _jumpForce;
    }
    
    public void Rotate(Vector3 _rotation)
    {
        rotation = _rotation;
    }
    
    public void RotateCamera(Vector3 _cameraRotation)
    {
        cameraRotation = _cameraRotation;
    }

    private void FixedUpdate()
    {
        PerformMovement();
        PerformRotation();
        PerformJump();  
    }

    private void PerformMovement()
    {
        if (velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
    }
    
    private void PerformRotation()
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));
        cam.transform.Rotate(-cameraRotation);
    }

    private void PerformJump()
    {   
        if (Physics.OverlapSphere(groundCheck.position,radius,collisionLayers).Length > 0)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
 
        if (isJumping && isGrounded)
        {
            rb.AddForce(new Vector3(0f,jumpForce,0f));
            playerController.GetComponent<PlayerController>().isJumping = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position,radius);
    }
}
