using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoutiqueManager : MonoBehaviour
{
    public float[] currentWeapon;
    public PlayerWeapon playerWeapon;
    public float currentRange = 100f;
    public float currentDamage = 10f;
    public float currentTailleChargeur = 10f;

    public PlayerShoot playerShoot;
    

    public bool boolPistolet = false;
    public bool boolMitraillette = false;
    public bool boolFusilAssault = false;
    public bool boolSniper = false;



    private void Start()
    {
        currentWeapon = playerWeapon.Pistolet; // Initialise la premiere arme a Pistolet. Toute les valeurs de la liste de Pistolet pourra etre recuperer ici
        currentRange = currentWeapon[1]; // Initialise la portée de la premiere arme
        currentDamage = currentWeapon[0]; 
        currentTailleChargeur = currentWeapon[3];
    }

    void Update()
    {
        if (boolPistolet) // Si on souhaite changer d'arme le booleen se met a true
        {
            currentWeapon = playerWeapon.Pistolet; // Change l'arme actuel en Pistolet et toutes les valeurs sont changées
            currentDamage = playerWeapon.Pistolet[0];
            currentRange = playerWeapon.Pistolet[1];
            currentTailleChargeur = playerWeapon.Pistolet[3];
            playerShoot.GetComponent<PlayerShoot>().munRestante = currentTailleChargeur;
            boolPistolet = false; // Remet le booleen a false pour que le changement ne se fasse pas en permanence
        }
        
        if (boolMitraillette)
        {
            currentWeapon = playerWeapon.Mitraillette;
            currentDamage = playerWeapon.Mitraillette[0];
            currentRange = playerWeapon.Mitraillette[1];
            currentTailleChargeur = playerWeapon.Mitraillette[3];
            playerShoot.GetComponent<PlayerShoot>().munRestante = currentTailleChargeur;
            boolMitraillette = false;
        }
        
        if (boolFusilAssault)
        {
            currentWeapon = playerWeapon.FusilAssault;
            currentDamage = playerWeapon.FusilAssault[0];
            currentRange = playerWeapon.FusilAssault[1];
            currentTailleChargeur = playerWeapon.FusilAssault[3];
            playerShoot.GetComponent<PlayerShoot>().munRestante = currentTailleChargeur;
            boolFusilAssault = false;
        }
        
        if (boolSniper)
        {    
            currentWeapon = playerWeapon.Sniper;
            currentDamage = playerWeapon.Sniper[0];
            currentRange = playerWeapon.Sniper[1];
            currentTailleChargeur = playerWeapon.Sniper[3];
            playerShoot.GetComponent<PlayerShoot>().munRestante = currentTailleChargeur;
            boolSniper = false;
        }
    }

    public void ChangePistolet()
    {
        boolPistolet = true; // Change le booleen du Pistolet pour changer son arme actuel en pistolet et pour pouvoir faire les changements de variables
        boolMitraillette = false; // Pour s'assurer que les autres booleens sont bien a false
        boolFusilAssault = false;
        boolSniper = false;
    }
    
    public void ChangeMitraillette()
    {
        boolMitraillette = true;
        boolPistolet = false;
        boolFusilAssault = false;
        boolSniper = false;
    }
    
    public void ChangeFusilAssault()
    {
        boolFusilAssault = true;
        boolMitraillette = false;
        boolPistolet = false;
        boolSniper = false;
    }
    
    public void ChangeSniper()
    {
        boolSniper = true;
        boolMitraillette = false;
        boolFusilAssault = false;
        boolPistolet = false;
    }
}
