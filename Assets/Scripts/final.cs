using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final : MonoBehaviour
{
    Vector3 startPos;

        private void Start()
    {
        startPos = this.transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Final"))
        {
            this.transform.position = startPos;

        }
    }

}




