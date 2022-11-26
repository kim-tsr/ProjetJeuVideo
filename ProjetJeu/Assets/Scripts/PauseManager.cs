using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public Canvas canvasPause;
    public Canvas canvasTouches;
    public Canvas canvasCrosshair;

    public PlayerController playerController;

    public GameManager gameManager;

    public void ChangerTouches()
    {
        canvasPause.enabled = false;
        canvasTouches.enabled = true;
    }

    public void Resume()
    {
        canvasPause.enabled = false;
        canvasCrosshair.enabled = true;
        playerController.moov = true;
        gameManager.GetComponent<GameManager>().boolBoutique = true;
    }
}
