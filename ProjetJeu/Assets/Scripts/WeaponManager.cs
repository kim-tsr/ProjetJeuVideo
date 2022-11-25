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

    public BoutiqueManager boutiqueManager;

    public Transform weaponHolder;

    public string weaponLayerName = "Weapon";

    private void Start()
    {
        EquipWeapon(primaryWeapon);
        currentWeapon = boutiqueManager.currentWeapon;
    }

    public float[] GetCurrentWeapon()
    {
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

    public void Munition()
    {
        
    }
}
