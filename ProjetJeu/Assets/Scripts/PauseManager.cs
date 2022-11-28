using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public Canvas canvasPause;
    public Canvas canvasTouches;
    public Canvas canvasCrosshair;

    public PlayerController playerController;

    public MenuManager gameManager;

    public void ChangerTouches() // Quand on appuye sur le bouton Changer Touche
    {
        canvasPause.enabled = false; // On ferme le menu Pause
        canvasTouches.enabled = true; // Pour ouvrir le menu pour changer less touches
    }

    public void Resume() // Quand on appuye sur le bouton Resume
    {
        canvasPause.enabled = false; // Ferme le menu Pause
        canvasCrosshair.enabled = true; // Remet en place le canvas du cross hair
        playerController.moov = true; // Remet en place les mouvements, l'utilisateur peut rejouer
        gameManager.GetComponent<MenuManager>().boolBoutique = true; // Autorise l'ouverture du menu boutique puisque le menu Pause est ferme
    }
}
