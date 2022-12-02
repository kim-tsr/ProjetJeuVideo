using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventaireManager : MonoBehaviour
{
    public GameObject[] listeInventaire;
    public int[] listeNbrInventaire;

    public GameObject heal;
    public GameObject munFa;
    public GameObject munMitraillette;
    public GameObject munSniper;
    public GameObject grenade;
    public GameObject arme1;
    public GameObject arme2;

    public void Start()
    {
        listeInventaire = new[] {heal, munMitraillette, munFa, munSniper, grenade, arme1, arme2};
        listeNbrInventaire = new[] {0, 0, 0, 0, 0 , 1, 1};
    }
}
