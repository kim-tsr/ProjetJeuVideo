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

    public bool changeAvancer = false;
    public bool changeReculer = false;
    public bool changeDroite = false;
    public bool changeGauche = false;
    public bool changeJump = false;
    public bool changeSlow = false;
    public bool changeReload = false;
    public bool changeBoutique = false;

    public Text textAvancer;
    public Text textReculer;
    public Text textDroite;
    public Text textGauche;
    public Text textJump;
    public Text textSlow;
    public Text textReload;
    public Text textBoutique;

    public KeyCode keyAvancer = KeyCode.Z;
    public KeyCode keyReculer = KeyCode.S;
    public KeyCode keyDroite = KeyCode.D;
    public KeyCode keyGauche = KeyCode.Q;
    public KeyCode keyJump = KeyCode.Space;
    public KeyCode keySlow = KeyCode.LeftShift;
    public KeyCode keyReload = KeyCode.R;
    public KeyCode keyBoutique = KeyCode.B;


    public void Update()
    {
        if (changeAvancer)
        {
            foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(keyCode))
                {
                    avancer = keyCode.ToString();
                    keyAvancer = keyCode;
                    textAvancer.text = avancer;
                    changeAvancer = false;
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
    }

    public void ChangeAvancer()
    {
        changeAvancer = true;
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

    public void Return()
    {
        canvasTouches.enabled = false;
        canvasPause.enabled = true;
    }
}
