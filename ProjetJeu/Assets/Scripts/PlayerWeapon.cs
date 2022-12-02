using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerWeapon
{
    public float[] Pistolet = new[] {10f, 100f, 0f, 10f}; // Liste des valeurs d'une arme 
    public float[] Mitraillette = new[] {20f, 250f, 0f, 20f}; 
    public float[] FusilAssault = new[] {40f, 500f, 0f, 30f}; 
    public float[] Sniper = new[] {100f, 1000f, 0f, 5f};
    public float[] Cut = new[] {34f,10f,0f,1f};

    /*
     * arme[0] = damage
     * arme[1] = range
     * arme[2] = fireRate
     * arme[3] = tailleChargeur
     * arme[4] = graphic
     * arme[5] =
     * arme[6] =
     * arme[7] =
     */
}
