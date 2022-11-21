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

    public bool changeAvancer = false;
    public bool changeReculer = false;
    public bool changeDroite = false;
    public bool changeGauche = false;

    public Text textAvancer;
    public Text textReculer;
    public Text textDroite;
    public Text textGauche;

    public KeyCode keyAvancer = KeyCode.Z;
    public KeyCode keyReculer = KeyCode.S;
    public KeyCode keyDroite = KeyCode.D;
    public KeyCode keyGauche = KeyCode.Q;

    
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

    public void Return()
    {
        canvasTouches.enabled = false;
        canvasPause.enabled = true;
    }
}
