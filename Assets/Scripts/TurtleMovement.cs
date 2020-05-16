using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleMovement : MonoBehaviour
{
    public float movementDistance = 6f;
    public float movementSpeed = 2.0f;
    private Vector3 startingPosition;

    void Start()
    {
        startingPosition = transform.position;
    }

    void Update()
    {
        Vector3 movementDirection = startingPosition;
        movementDirection.z += movementDistance * Mathf.Sin(Time.time * movementSpeed);
        transform.position = movementDirection;
    }
}