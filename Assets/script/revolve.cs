using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revolve : MonoBehaviour
{
    public Transform centerPoint; // The center point to revolve around
    public float radius = 5.0f; // The radius of the revolution
    public float speed = 1.0f; // The speed of revolution

    // Update is called once per frame
    void Update()
    {
        // Calculate the new position of the sphere based on the center point and radius
        Vector3 newPosition = centerPoint.position + new Vector3(0, transform.position.y - centerPoint.position.y, 0).normalized * radius;

        // Set the new position of the sphere
        transform.position = newPosition;

        // Rotate the sphere around the center point in the y-axis
        transform.RotateAround(centerPoint.position, Vector3.up, speed * Time.deltaTime);
    }
}

