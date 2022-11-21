using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject canvasPause;
    public GameObject canvasCrosshair;
    public PlayerController playerController;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canvasCrosshair.GetComponent<Canvas>().enabled = false;
            canvasPause.GetComponent<Canvas>().enabled = true;
            playerController.moov = false;
        }
    }
}
