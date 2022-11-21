using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public PlayerWeapon primaryWeapon;

    private PlayerWeapon currentWeapon;
    private PlayerWeapon currentGraphics;

    public Transform weaponHolder;

    public string weaponLayerName = "Weapon";

    private void Start()
    {
        EquipWeapon(primaryWeapon);
    }

    public PlayerWeapon GetCurrentWeapon()
    {
        return currentWeapon;
    }
    
    public PlayerWeapon GetCurrentGraphics()
    {
        return currentGraphics;
    }

    void EquipWeapon(PlayerWeapon _weapon)
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
