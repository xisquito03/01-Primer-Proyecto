using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneda : MonoBehaviour
{
    public GameObject coin;
    public int rotateSpeed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            coin.SetActive(false);
            
        }
    }


    private void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }

}
