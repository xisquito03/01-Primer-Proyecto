using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuerapasillo : MonoBehaviour
{
    
    public GameObject suelo;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            suelo.SetActive(false);
        }
    }
}

