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

    public bool boolPause = true;
    public bool boolBoutique = true;

    public ChangeTouches changeTouches;
    public KeyCode keyBoutique;

    void Update()
    {
        keyBoutique = changeTouches.keyBoutique;
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (boolPause)
            {
                canvasCrosshair.GetComponent<Canvas>().enabled = false;
                canvasPause.GetComponent<Canvas>().enabled = true;
                playerController.moov = false;
                boolBoutique = false;
            }
        }
        
        if (Input.GetKeyDown(keyBoutique))
        {
            if (boolBoutique)
            {
                if (canvasBoutique.GetComponent<Canvas>().enabled)
                {
                    canvasCrosshair.GetComponent<Canvas>().enabled = true;
                    canvasBoutique.GetComponent<Canvas>().enabled = false;
                    playerController.moov = true;
                    boolPause = true;
                }
                else
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
