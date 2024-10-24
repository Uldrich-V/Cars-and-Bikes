using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public float acceleration = 5f;
    public float currentSpeed = 0f;
    public float maxSpeed = 100f;
    public virtual void Accelerate()
    {
        if (currentSpeed < maxSpeed)
        {
            currentSpeed += acceleration * Time.deltaTime;
        }
    }

    public float GetSpeed()
    {
        return currentSpeed;
    }
}
