using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3f;
    public float mouseSensitivity = 3f;

    private PlayerMotor motor;

    public ChangeTouches touches;

    private float xMov;
    private float zMov;

    public KeyCode keyAvancer;
    public KeyCode keyReculer;
    public KeyCode keyDroite;
    public KeyCode keyGauche;

    public bool moov = true;

    void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }

    void Update()
    {
        if (moov)
        {
            keyAvancer = touches.keyAvancer;
                    keyReculer = touches.keyReculer;
                    keyDroite = touches.keyDroite;
                    keyGauche = touches.keyGauche;
                    
                    if (Input.GetKeyDown(KeyCode.LeftShift))
                    {
                        speed = speed / 2f;
                    }
            
                    if (Input.GetKeyUp(KeyCode.LeftShift))
                    {
                        speed = speed * 2f;
                    }
            
                    if (Input.GetKeyDown(keyAvancer))
                    {
                        zMov = 1f;
                    }
                    if (Input.GetKeyUp(keyAvancer))
                    {
                        zMov = 0;
                    }
            
                    if (Input.GetKeyDown(keyReculer))
                    {
                        zMov = -1f;
                    }
                    if (Input.GetKeyUp(keyReculer))
                    {
                        zMov = 0;
                    }
            
                    if (Input.GetKeyDown(keyDroite))
                    {
                        xMov = 1f;
                    }
                    if (Input.GetKeyUp(keyDroite))
                    {
                        xMov = 0;
                    }
            
                    if (Input.GetKeyDown(keyGauche))
                    {
                        xMov = -1f;
                    }
                    if (Input.GetKeyUp(keyGauche))
                    {
                        xMov = 0;
                    }
            
                    Vector3 moveHorizontal = transform.right * xMov;
                    Vector3 moveVertical = transform.forward * zMov;
            
                    Vector3 velocity = (moveHorizontal + moveVertical).normalized * speed;
            
                    motor.Move(velocity);
            
                    float yRot = Input.GetAxisRaw("Mouse X");
            
                    Vector3 rotation = new Vector3(0, yRot, 0) * mouseSensitivity;
            
                    motor.Rotate(rotation);
                    
                    
                    
                    float xRot = Input.GetAxisRaw("Mouse Y");
            
                    Vector3 cameraRotation = new Vector3(xRot, 0, 0) * mouseSensitivity;
            
                    motor.RotateCamera(cameraRotation);
        }
    }
}