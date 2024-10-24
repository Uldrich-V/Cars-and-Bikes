using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bike : Vehicle
{
    public override void Accelerate()
    {
        if (currentSpeed < maxSpeed)
        {
            currentSpeed += acceleration * Time.deltaTime * 0.8f;  // Bikes accelerate slower
        }
    }
}

