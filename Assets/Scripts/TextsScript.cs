using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class TextsScript : MonoBehaviour
{
    // public
    public string[] texts;
    
    void Awake()
    {
        // create list
        StartString();
    }
    
    void Update()
    {
        
    }

    void StartString()
    {
        texts = new[]
        {
            "Phone",
            "Laptop",
            "Watch",
            "Clock",
            "Fan",
            "Charger",
            "Tablet",
            "Monitor",
            "Keyboard",
            "Heater",
            "Cooler",
            "Mouse",
            "Cable",
            "Air Conditioner",
            "Headphone",
            "Router",
            "Speaker",
            "Key Card",
            "Door Bell",
            "Table Lamp",
            "Camera",
            "Controller",
            "Console",
            "Television",
            "Earphones",
            "Earbuds",
            "Solar Panel",
            "Screen"
        };
    }

    public string GetRandomString()
    {
        int RN = Random.Range(0, texts.Length);

        return texts[RN];
    }
}
