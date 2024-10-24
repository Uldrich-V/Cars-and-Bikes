using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    public override void Accelerate()
    {
        if (currentSpeed < maxSpeed)
        {
            currentSpeed += acceleration * Time.deltaTime * 1.5f;  // Auto má větší zrychlení než kolo...
        }
    }
}
