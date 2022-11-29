using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aparecerpuerta : MonoBehaviour
{
    public GameObject puerta;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            puerta.SetActive(true);
        }
    }
}
