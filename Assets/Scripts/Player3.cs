using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3 : MonoBehaviour
{
    public float speed = 5f;

    public void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal3");
        float verticalInput = Input.GetAxis("Vertical3");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
