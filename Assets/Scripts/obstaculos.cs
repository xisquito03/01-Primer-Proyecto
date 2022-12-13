using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {

            Destroy(player);
            Debug.Log("Game Over");
            Time.timeScale = 0;

        }
    }
}
