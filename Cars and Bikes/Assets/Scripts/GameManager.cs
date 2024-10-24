using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Vehicle car1;  // Auto...
    public Vehicle bike1; // Kolo...

    public Text car1SpeedText;
    public Text bike1SpeedText;
    public Text speedDifferenceText;

    private void Update()
    {
        // zrychluje obě vozidla při zmáčknutí
        if (Input.GetKey(KeyCode.Space))
        {
            car1.Accelerate();
            bike1.Accelerate();
        }

        // Ukazuje rychlosti
        car1SpeedText.text = "Car 1 Speed: " + car1.GetSpeed().ToString("F2") + " km/h";
        bike1SpeedText.text = "Bike 1 Speed: " + bike1.GetSpeed().ToString("F2") + " km/h";

        // Počítá a ukazuje rozdíl rychlostí vozidel
        float speedDifference = Mathf.Abs(car1.GetSpeed() - bike1.GetSpeed());
        speedDifferenceText.text = "Speed Difference: " + speedDifference.ToString("F2") + " km/h";
    }
}
