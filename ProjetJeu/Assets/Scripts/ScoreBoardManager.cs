using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardManager : MonoBehaviour
{
    public Text[] listeNomBlue;
    public Text[] listeNomRed;
    public Text[] listeKillBlue;
    public Text[] listeKillRed;
    public Text[] listeMortBlue;
    public Text[] listeMortRed;

    public GameObject dontDestroy;

    public int place;
    public string team;
    public string name;

    public PhotonView View;

    public void Start()
    {
        dontDestroy = GameObject.FindGameObjectWithTag("DontDestroy");
        team = dontDestroy.GetComponent<DontDestroy>().team;
        name = dontDestroy.GetComponent<DontDestroy>().name;
        place = dontDestroy.GetComponent<DontDestroy>().place;
        View.RPC("MettreNom",RpcTarget.All,place,team,name);
    }

    public void EstMort()
    {
        View.RPC("ChangeMort",RpcTarget.All,place,team);
    }

    public void FaitKill()
    {
        View.RPC("ChangeKill",RpcTarget.All,place,team);
    }
    
    [PunRPC]
    public void MettreNom(int place_, string team_, string name_)
    {
        if (team_ == "blue")
        {
            listeNomBlue[place_].text = name_;
        }
        
        if (team_ == "red")
        {
            listeNomRed[place_].text = name_;
        }
    }

    [PunRPC]
    public void ChangeKill(int place_, string team_)
    {
        if (team_ == "blue")
        {
            listeKillBlue[place_].text = (int.Parse(listeKillBlue[place_].text) + 1).ToString();
        }
        
        if (team_ == "red")
        {
            listeKillRed[place_].text = (int.Parse(listeKillRed[place_].text) + 1).ToString();
        }
    }
    
    [PunRPC]
    public void ChangeMort(int place_, string team_)
    {
        if (team_ == "blue")
        {
            listeMortBlue[place_].text = (int.Parse(listeMortBlue[place_].text) + 1).ToString();
        }
        
        if (team_ == "red")
        {
            listeMortRed[place_].text = (int.Parse(listeMortRed[place_].text) + 1).ToString();
        }
    }
}
