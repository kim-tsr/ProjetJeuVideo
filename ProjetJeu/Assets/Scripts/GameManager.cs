using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject canvasPause;
    public GameObject canvasCrosshair;
    public GameObject canvasBoutique;
    public PlayerController playerController;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canvasCrosshair.GetComponent<Canvas>().enabled = false;
            canvasPause.GetComponent<Canvas>().enabled = true;
            playerController.moov = false;
        }
        
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (canvasBoutique.GetComponent<Canvas>().enabled)
            {
                canvasCrosshair.GetComponent<Canvas>().enabled = true;
                canvasBoutique.GetComponent<Canvas>().enabled = false;
                playerController.moov = true;
            }
            else
            {
                canvasCrosshair.GetComponent<Canvas>().enabled = false;
                canvasBoutique.GetComponent<Canvas>().enabled = true;
                playerController.moov = false;
            }
        }
    }
}
