using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muerte : MonoBehaviour
{
   
    public float lowerLimit = -7.06f;


    private void Update()
    {
        if (transform.position.y < lowerLimit)
        {
            Destroy(gameObject);
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
        }
    }
}


