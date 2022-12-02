using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincounter : MonoBehaviour
{
    public GameObject coin;
    public int coins;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Coin"))
        {
            coinCounter();
            Debug.Log($"{coins}");

        }
    }

    private void coinCounter()
    {
        coins++;
    }
}
