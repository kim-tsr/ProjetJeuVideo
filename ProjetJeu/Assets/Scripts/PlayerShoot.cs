using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(WeaponManager))]
public class PlayerShoot : MonoBehaviour
{

    public Camera cam;

    public float[] currentWeapon;
    public float currentRange;
    public float currentDamage;
    public float tailleChargeur;
    public float munRestante;

    public LayerMask mask;

    public WeaponManager weaponManager;

    public ParticleSystem flareSmoke;

    public GameObject impactBalle;

    public PlayerController playerController;

    public BoutiqueManager boutiqueManager;
    
    void Start()
    {
        if (cam == null)
        {
            Debug.LogError("Pas de cam pour le système de tir");
            this.enabled = false;
        }
    }

    private void Update()
    {
        currentWeapon = weaponManager.GetCurrentWeapon();
        currentRange = currentWeapon[1];
        tailleChargeur = currentWeapon[3];
        
        
        
        if (Input.GetButtonDown("Fire1"))
        {
            if (playerController.moov)
            {
                if (munRestante>0)
                {
                    Shoot();
                    munRestante -= 1;
                }
            }
        }
    }

    private void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, currentRange, mask))
        {
            Debug.Log("Objet touché : "+hit.collider.name);
            Vector3 pos = hit.point;
            Vector3 normal = hit.normal;
            GameObject hitEffect = Instantiate(impactBalle, pos, Quaternion.LookRotation(normal));
            Destroy(hitEffect,2f);
        }

        flareSmoke.Play();
    }
}
