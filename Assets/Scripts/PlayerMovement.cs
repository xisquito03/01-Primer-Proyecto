using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 15f;
    public float turnspeed =10f;
    private float horizontalInput;
    private float verticalInput;

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        transform.Rotate(Vector3.up, turnspeed * Time.deltaTime * horizontalInput);
    }
}
