using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviourPun
{
    public float life = 100f;

    public Text texteLife;

    public GameObject MainCamera;

    public PhotonView photonView;

    public Canvas canvasScoreBoard;
    
    public void Start()
    {
        photonView = PhotonView.Get(this);
    }

    public void Update()
    {
        if (texteLife != null)  // Pour pouvoir faire les tests avec les cubes
        {
            texteLife.text = life.ToString(); //Affiche la vie avec l'objet texte qui se trouve dans Canvas Crosshair
        }
        
        if (life <= 0)
        {
            canvasScoreBoard.GetComponent<ScoreBoardManager>().EstMort();
            MainCamera = GameObject.FindGameObjectWithTag("MainCamera");
            MainCamera.SetActive(true);
            
            photonView.RPC("Kill", RpcTarget.All);
            
        }
    }

    [PunRPC]
    public void Kill()
    {
        this.gameObject.SetActive(false);
    }
}
