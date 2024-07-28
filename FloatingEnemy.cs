using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script for floating enemy
public class FloatingEnemy : MonoBehaviour
{
    public float amplitude = 1.0f; // height
    public float frequency = 1.0f; // speed
    public float verticalOffset = 0.0f; // Vertical offset from the initial position

    private Vector3 startPos;

    void Start()
    {
        // Store the starting position
        startPos = transform.position;
    }

    void Update()
    {
        // Calculate the new vertical position using a sine wave
        float newY = startPos.y + Mathf.Sin(Time.time * frequency) * amplitude + verticalOffset;

        // Update the enemy's position
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
