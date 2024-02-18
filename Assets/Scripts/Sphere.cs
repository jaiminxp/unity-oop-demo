using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{
    Sphere()
    {
        ShapeName = "Silly";
    }

    // POLYMORPHISM
    public override void DisplayText()
    {
        // ABSTRACTION
        textObject.text = "I am a Sphere!";
    }
}
