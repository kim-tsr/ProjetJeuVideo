using System;
using System.Collections;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

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

    public Text texteMunRestante;
    public Text texteTailleChargeur;

    public ChangeTouches changeTouches;
    public KeyCode keyReload;

    public GameManager gameManager;

    public LayerMask maskEnnemie;
    
    void Start()
    {
        if (cam == null) // S'assure qu'on est une cam et qu'on peut donc tirer
        {
            Debug.LogError("Pas de cam pour le système de tir");
            this.enabled = false;
        }
        
        currentWeapon = weaponManager.GetCurrentWeapon(); // Initialise les valeurs de l'arme avec WeaponManager
        currentRange = currentWeapon[1];
        currentDamage = currentWeapon[0];
        tailleChargeur = currentWeapon[3];
        munRestante = tailleChargeur;

        texteMunRestante.text = munRestante.ToString(); // Affiche sur le texte MunRestante les balles qu'il reste dans le chargeur
        texteTailleChargeur.text = tailleChargeur.ToString(); // Affiche sur le texte TailleChargeur les balles qu'il y a dans un chargeur
    }

    private void Update()
    {
        currentWeapon = weaponManager.GetCurrentWeapon(); // Met a jour en permanence les valeurs des armes 
        currentRange = currentWeapon[1];
        currentDamage = currentWeapon[0];
        tailleChargeur = currentWeapon[3];
        
        texteMunRestante.text = munRestante.ToString();
        texteTailleChargeur.text = tailleChargeur.ToString();

        keyReload = changeTouches.keyReload; // Recupere la touche de Reload dans le script ChangeTouches

        if (Input.GetKeyDown(keyReload)) // Si l'utilisateur appuye sur la touche de Reload
        {
            Reload(); // Appelle la fonction Reload plus bas
        }
        
        if (Input.GetButtonDown("Fire1")) // Si il appuye sur la touche pour tirer (deja defini dans Unity)
        {
            if (playerController.moov) // On s'assure que le joueur a le droit de se deplacer et de tirer
            {
                if (munRestante>0) // Si il reste des balles dans le chargeur
                {
                    Shoot(); // Appelle la fonction de tir plus bas
                    munRestante -= 1; // Enleve une balle dans le chargeur
                }
            }
        }
    }

    private void Shoot()
    {
        RaycastHit hit; // Defini un point de collision

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, currentRange, mask)) // Si il y a bien une collision sur l'objet souhaite
        {
            Debug.Log("Objet touché : "+hit.collider.name); // Affiche dans la Console la collision

            hit.transform.gameObject.GetComponent<PlayerLife>().life -= currentDamage; // Enleve la vie du GameObject qui a recu le hit
            // La vie est recuperer grace au script PlayerLife. On lui enleve les degats que fait l'arme que possede le joueur qui a tire
            
            Vector3 pos = hit.point; // On recupere le point de collision sous forme de vecteur 
            Vector3 normal = hit.normal; // On normalise le vecteur du point d'impact
            GameObject hitEffect = Instantiate(impactBalle, pos, Quaternion.LookRotation(normal)); // Pour pouvoir faire spawn l'effet de hit a l'endroit voulu et dans le sens voulu
            Destroy(hitEffect,2f); // On detruit l'effet de hit apres deux secondes
        }

        flareSmoke.Play(); // On fait jouer l'effet de fume a la sortie de l'arme
    }

    private void Reload()
    {
        munRestante = tailleChargeur; // Remet le nombre de balle souhaite dans le chargeur
    }
}
