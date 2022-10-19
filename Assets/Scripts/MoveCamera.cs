using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveCamera : MonoBehaviour
{
    //movement speed in units per second
    public float movementSpeed = 10f;
    public Vector3 pivotPoint = new Vector3(4f, 4f, 4f);
    void Update()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        //update the position
        //transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, 0, verticalInput * movementSpeed * Time.deltaTime);
        // Vector3 pivotPoint = new Vector3(0f,50f,0f);
        transform.RotateAround(pivotPoint, Vector3.up, 90 * Time.deltaTime);
    }
}