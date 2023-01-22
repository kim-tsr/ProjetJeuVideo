using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTouches : MonoBehaviour
{
    public Canvas canvasTouches;
    public Canvas canvasPause;
    
    public string avancer = "Z";
    public string reculer = "S";
    public string droite = "D";
    public string gauche = "Q";
    public string jump = "Space";
    public string slow = "LeftShift";
    public string reload = "R";
    public string boutique = "B";
    public string changeArme1 = "Alpha1";
    public string changeArme2 = "Alpha2";
    public string changeCut = "Alpha3";
    public string inventaire = "Tab";

    public bool changeAvancer = false;
    public bool changeReculer = false;
    public bool changeDroite = false;
    public bool changeGauche = false;
    public bool changeJump = false;
    public bool changeSlow = false;
    public bool changeReload = false;
    public bool changeBoutique = false;
    public bool changeChangeArme1 = false;
    public bool changeChangeArme2 = false;
    public bool changeChangeCut = false;
    public bool changeInventaire = false;

    public Text textAvancer;
    public Text textReculer;
    public Text textDroite;
    public Text textGauche;
    public Text textJump;
    public Text textSlow;
    public Text textReload;
    public Text textBoutique;
    public Text textChangeArme1;
    public Text textChangeArme2;
    public Text textChangeCut;
    public Text textInventaire;

    public KeyCode keyAvancer = KeyCode.Z;
    public KeyCode keyReculer = KeyCode.S;
    public KeyCode keyDroite = KeyCode.D;
    public KeyCode keyGauche = KeyCode.Q;
    public KeyCode keyJump = KeyCode.Space;
    public KeyCode keySlow = KeyCode.LeftShift;
    public KeyCode keyReload = KeyCode.R;
    public KeyCode keyBoutique = KeyCode.B;
    public KeyCode keyChangeArme1 = KeyCode.Alpha1;
    public KeyCode keyChangeArme2 = KeyCode.Alpha2;
    public KeyCode keyChangeCut = KeyCode.Alpha3;
    public KeyCode keyInventaire = KeyCode.Tab;


    public void Update()
    {
        if (changeAvancer) // Pour changer la touche pour avancer
        {
            foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode))) // Parcours les keycode pour voir lequel a ete rentre
            {
                if (Input.GetKeyDown(keyCode)) // Si le keycode a ete trouve
                {
                    avancer = keyCode.ToString(); // on change la valeur de avancer qui va nous permettre d'afficher la touche a l'utilisateur
                    keyAvancer = keyCode; // Change la key avancer avec celle trouver
                    textAvancer.text = avancer; // Change l'affichage pour l'utilisateur
                    changeAvancer = false; // Ferme le if une fois que tout est fini pour que ca ne tourne pas en boucle
                }
            }
        }

        if (changeReculer)
        {
            foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(keyCode))
                {
                    reculer = keyCode.ToString();
                    keyReculer = keyCode;
                    textReculer.text = reculer;
                    changeReculer = false;
                }
            }
        }

        if (changeDroite)
        {
            foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(keyCode))
                {
                    droite = keyCode.ToString();
                    keyDroite = keyCode;
                    textDroite.text = droite;
                    changeDroite = false;
                }
            }
        }

        if (changeGauche)
        {
            foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(keyCode))
                {
                    gauche = keyCode.ToString();
                    keyGauche = keyCode;
                    textGauche.text = gauche;
                    changeGauche = false;
                }
            }
        }
        
        if (changeJump)
        {
            foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(keyCode))
                {
                    jump = keyCode.ToString();
                    keyJump = keyCode;
                    textJump.text = jump;
                    changeJump = false;
                }
            }
        }
        
        if (changeSlow)
        {
            foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(keyCode))
                {
                    slow = keyCode.ToString();
                    keySlow = keyCode;
                    textSlow.text = slow;
                    changeSlow = false;
                }
            }
        }
        
        if (changeReload)
        {
            foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(keyCode))
                {
                    reload = keyCode.ToString();
                    keyReload = keyCode;
                    textReload.text = reload;
                    changeReload = false;
                }
            }
        }
        
        if (changeBoutique)
        {
            foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(keyCode))
                {
                    boutique = keyCode.ToString();
                    keyBoutique = keyCode;
                    textBoutique.text = boutique;
                    changeBoutique = false;
                }
            }
        }
        
        if (changeChangeArme1)
        {
            foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(keyCode))
                {
                    changeArme1 = keyCode.ToString();
                    keyChangeArme1 = keyCode;
                    textChangeArme1.text = changeArme1;
                    changeChangeArme1 = false;
                }
            }
        }
        
        if (changeChangeArme2)
        {
            foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(keyCode))
                {
                    changeArme2 = keyCode.ToString();
                    keyChangeArme2 = keyCode;
                    textChangeArme2.text = changeArme2;
                    changeChangeArme2 = false;
                }
            }
        }
        
        if (changeChangeCut)
        {
            foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(keyCode))
                {
                    changeCut = keyCode.ToString();
                    keyChangeCut = keyCode;
                    textChangeCut.text = changeCut;
                    changeChangeCut = false;
                }
            }
        }
        
        if (changeInventaire)
        {
            foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(keyCode))
                {
                    inventaire = keyCode.ToString();
                    keyInventaire = keyCode;
                    textInventaire.text = inventaire;
                    changeInventaire = false;
                }
            }
        }
    }

    public void ChangeAvancer()
    {
        changeAvancer = true; // Ouvre le if dans Update pour changer la touche
    }
    
    public void ChangeReculer()
    {
        changeReculer = true;
    }
    
    public void ChangeDroit()
    {
        changeDroite = true;
    }
    
    public void ChangeGauche()
    {
        changeGauche = true;
    }
    
    public void ChangeJump()
    {
        changeJump = true;
    }
    
    public void ChangeSlow()
    {
        changeSlow = true;
    }
    
    public void ChangeReload()
    {
        changeReload = true;
    }
    
    public void ChangeBoutique()
    {
        changeBoutique = true;
    }
    
    public void ChangeChangeArme1()
    {
        changeChangeArme1 = true;
    }
    
    public void ChangeChangeArme2()
    {
        changeChangeArme2 = true;
    }
    
    public void ChangeChangeCut()
    {
        changeChangeCut = true;
    }

    public void ChangeInventaire()
    {
        changeInventaire = true;
    }

    public void Return()
    {
        canvasTouches.enabled = false; //  Retourne au menu d'avant en fermant le canvasTouches
        canvasPause.enabled = true; // pour ouvrir le canvasPause
    }
}
