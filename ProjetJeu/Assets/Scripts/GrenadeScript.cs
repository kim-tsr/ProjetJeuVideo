using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeScript : MonoBehaviour
{
    public float sec = 2f;
    public bool boom = false;
    public GameObject particules;

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(Explositon());
    }

    IEnumerator Explositon()
    {
        yield return new WaitForSeconds(sec);
        boom = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (!boom)
        {
            return;   
        }

        if (other.CompareTag("Mur"))
        {
            other.GetComponent<PlayerLife>().life -= 80;
        }

        if (particules != null)
        {
            Instantiate(particules, transform.position, Quaternion.identity);
        }

        Destroy(gameObject);
    }
}
