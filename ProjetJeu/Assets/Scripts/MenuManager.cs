using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject canvasPause;
    public GameObject canvasCrosshair;
    public GameObject canvasBoutique;
    public PlayerController playerController;

    public bool boolPause = true;
    public bool boolBoutique = true;

    public ChangeTouches changeTouches;
    public KeyCode keyBoutique;

    void Update()
    {
        keyBoutique = changeTouches.keyBoutique; // Recupere la touche prevu pour ouvrir la boutique dans le script ChangeTouches
        
        if (Input.GetKeyDown(KeyCode.Escape)) // Lorsque l'utilisateur appuye sur Echap
        {
            if (boolPause) // Si on peut ouvrir le menu, c'est a dire si aucun autre menu n'est ouvert
            {
                canvasCrosshair.GetComponent<Canvas>().enabled = false; // On ferme le canvas du crosshair
                canvasPause.GetComponent<Canvas>().enabled = true; // Pour ouvrir celui du menu Pause
                playerController.moov = false; // On arrete tout deplacement du joueur
                boolBoutique = false; // On empeche l'ouverture du menu de boutique
            }
        }
        
        if (Input.GetKeyDown(keyBoutique))
        {
            if (boolBoutique)
            {
                if (canvasBoutique.GetComponent<Canvas>().enabled) // Si le canvas est deja ouvert alors on le feme quand l'utilisateur re-appuye sur la touche
                {
                    canvasCrosshair.GetComponent<Canvas>().enabled = true;
                    canvasBoutique.GetComponent<Canvas>().enabled = false;
                    playerController.moov = true;
                    boolPause = true;
                }
                else // Sinon on l'ouvre
                {
                    canvasCrosshair.GetComponent<Canvas>().enabled = false;
                    canvasBoutique.GetComponent<Canvas>().enabled = true;
                    playerController.moov = false;
                    boolPause = false;
                }
            }
        }
    }
}
