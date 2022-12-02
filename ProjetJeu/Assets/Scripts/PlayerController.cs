using System;
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
    public KeyCode keyJump;
    public KeyCode keySlow;
    public KeyCode keyCut;
    public KeyCode keyArme;

    public bool isJumping;
    public float jumpForce;

    public bool moov = true;

    void Start()
    {
        motor = GetComponent<PlayerMotor>(); // Appelle le script PlayerMotor pour pouvoir y recuperer des elements
    }

    void Update()
    {
        if (moov) // Si le mouvement est autoriser (pas dans un menu)
        {
            keyAvancer = touches.keyAvancer; // Recupere les touches de deplacements
            keyReculer = touches.keyReculer;
            keyDroite = touches.keyDroite;
            keyGauche = touches.keyGauche;
            keyJump = touches.keyJump;
            keySlow = touches.keySlow;
            keyCut = touches.keyChangeCut;
            keyArme = touches.keyChangeArme;



            if (Input.GetKeyDown(keyCut))
            {
                this.GetComponent<WeaponManager>().boolCut = true;
                this.GetComponent<WeaponManager>().boolArme = false;
            }

            if (Input.GetKeyDown(keyArme))
            {
                this.GetComponent<WeaponManager>().boolCut = false;
                this.GetComponent<WeaponManager>().boolArme = true;
            }
            
            
            

            if (Input.GetKeyDown(keyJump)) // Si l'utilisateur demande a saute
            {
                isJumping = true; // Met le booleen a true, le traitement se fait plus bas
            }
            
            
            
            
            if (Input.GetKeyDown(keySlow)) // Si le joueur appuye pour Slow
            {
                speed = speed / 2f; // On reduit la vitesse de 2
            }
            
            if (Input.GetKeyUp(keySlow)) // Si il arrete de Slow
            {
                speed = speed * 2f; // On remet la vitesse comme avant
            }
            
            
            
            
            
            if (Input.GetKeyDown(keyAvancer)) // Deplacement sur les axes x et z
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
            
            Vector3 moveHorizontal = transform.right * xMov; // Creer un vecteur dans l'espace en focntion de la position du player et de la demande de le deplacer
            Vector3 moveVertical = transform.forward * zMov;
            
            Vector3 velocity = (moveHorizontal + moveVertical).normalized * speed; // Calcul la velocite a l'aide de la vitesse et des deux vecteurs precedents
            
            motor.Move(velocity); // Demande a faire le deplacement avec la fonction Move dans PlayerMotor
            
            float yRot = Input.GetAxisRaw("Mouse X"); // Recupere le deplacement de la souris sur l'axe y pour bouger la camera
            
            Vector3 rotation = new Vector3(0, yRot, 0) * mouseSensitivity; // Creer un vecteur a l'aide de la valeur yRot et de la sensibilité de la souris souhaité
            
            motor.Rotate(rotation); // Demande la rotation de la camera a l'aide de la fonction Rotate dans PlayerMotor

            float xRot = Input.GetAxisRaw("Mouse Y");
            
            Vector3 cameraRotation = new Vector3(xRot, 0, 0) * mouseSensitivity;
            
            motor.RotateCamera(cameraRotation);

            motor.Jump(isJumping,jumpForce); // Traitement du jump dans le script PlayerMotor
            /*isJumping = false;
            motor.Jump(isJumping,jumpForce);*/
        }
    }
}