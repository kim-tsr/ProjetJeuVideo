using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(WeaponManager))]
public class PlayerShoot : MonoBehaviour
{

    public Camera cam;

    private PlayerWeapon currentWeapon;

    public LayerMask mask;

    private WeaponManager weaponManager;

    public ParticleSystem flareSmoke;

    public GameObject impactBalle;

    public PlayerController playerController;
    
    void Start()
    {
        if (cam == null)
        {
            Debug.LogError("Pas de cam pour le système de tir");
            this.enabled = false;
        }

        weaponManager = GetComponent<WeaponManager>();
    }

    private void Update()
    {
        currentWeapon = weaponManager.GetCurrentWeapon();
            
        if (Input.GetButtonDown("Fire1"))
        {
            if (playerController.moov)
            {
                Shoot();
            }
        }
    }

    private void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, currentWeapon.range, mask))
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
