using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabMovement : MonoBehaviour
{
    public float movementDistance = 1.5f;  
    public float movementSpeed = 2.0f;
    private Vector3 startingPosition;

    void Start()
    {
        startingPosition = transform.position;
    }

    //The movement of the crab is updated here only for it's x axis and this method is responsible for also containing the speed movement and distance of the crabe.
    void Update()
    {
        Vector3 movementDirection = startingPosition;
        movementDirection.x += movementDistance * Mathf.Sin(Time.time * movementSpeed);
        transform.position = movementDirection;
    }
}