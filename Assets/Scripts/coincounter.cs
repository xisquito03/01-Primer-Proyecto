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

    private void Update()
    {
        if (coins == 23)
        {
            Destroy(gameObject);
            Debug.Log("Enhorabuena! Has completado el juego");
            Time.timeScale = 0;
        }
    }
}
