using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public float[] primaryWeapon;

    private float[] currentWeapon;
    private PlayerWeapon currentGraphics;

    public PlayerWeapon cut;

    public BoutiqueManager boutiqueManager;

    public Transform weaponHolder;

    public string weaponLayerName = "Weapon";

    public bool boolCut = false;
    public bool boolArme = false;
    public GameObject objectArme;
    public GameObject objectCut;

    private void Start()
    {
        EquipWeapon(primaryWeapon);
        currentWeapon = boutiqueManager.currentWeapon;
    }

    public float[] GetCurrentWeapon()
    {
        if (boolCut)
        {
            objectArme.SetActive(false);
            objectCut.SetActive(true);
            GetComponent<PlayerShoot>().boolCut = true;
            return cut.Cut;
        }

        if (boolArme)
        {
            objectArme.SetActive(true);
            objectCut.SetActive(false);
            GetComponent<PlayerShoot>().boolCut = false;
            GetComponent<PlayerShoot>().Reload();
        }
        return boutiqueManager.currentWeapon;
    }
    
    public PlayerWeapon GetCurrentGraphics()
    {
        return currentGraphics;
    }

    void EquipWeapon(float[] _weapon)
    {
        currentWeapon = _weapon;
        
        /*

        GameObject weaponIns = Instantiate(_weapon.graphics, weaponHolder.position, weaponHolder.rotation);
        weaponIns.transform.SetParent(weaponHolder);

        currentGraphics = weaponIns.GetComponent<WeaponGraphics>();

        if (currentGraphics == null)
        {
            Debug.LogError("Pas de script WeaponGraphics sur l'arme : "+weaponIns.name);
        }*/
    }
}
