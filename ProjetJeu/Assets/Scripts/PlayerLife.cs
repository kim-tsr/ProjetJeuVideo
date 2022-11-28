using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public float life = 100f;

    public Text texteLife;

    public void Update()
    {
        if (texteLife != null)  // Pour pouvoir faire les tests avec les cubes
        {
            texteLife.text = life.ToString(); //Affiche la vie avec l'objet texte qui se trouve dans Canvas Crosshair
        }
        
        if (life <= 0)
        {
            Destroy(this.gameObject); //Detruit l'objet car il n'a plus de vie
        }
    }
}
