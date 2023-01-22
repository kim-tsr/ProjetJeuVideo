using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunitionArme : MonoBehaviour
{
    public float munRestante;
    public float tailleChargeur;


    public float Reload(float ballesJoueur)
    {
        if (munRestante != tailleChargeur && ballesJoueur >= tailleChargeur)
        {
            munRestante = tailleChargeur;
            ballesJoueur -= tailleChargeur;
            return ballesJoueur;
        }
        
        munRestante = ballesJoueur;
        ballesJoueur = 0;
        return 0;
    }
}
