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
        if (other.tag.Equals("Meta"))
        {
            if (coins >= 15)
            {
                Debug.Log("YOU WON");
                gameObject.SetActive(false);
            }
            else
            {
                Debug.Log($"You are still missing {15-coins} coins, go look for them");
                transform.position = new Vector3(-1.15f, 0.54f, 2.97f);
            }
        }
        if (other.tag.Equals("Obstacle"))
        {
            transform.position = new Vector3(-1.15f, 0.54f, 2.97f);
            Debug.Log("Remember not to touch the obstacles");
        }
    }

    private void coinCounter()
    {
        coins++;
    }
}
