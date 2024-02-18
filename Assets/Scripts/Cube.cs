using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
    Cube()
    {
        ShapeName = "Cubey";
    }

    // POLYMORPHISM
    public override void DisplayText()
    {
        // ABSTRACTION
        textObject.text = "I am a Cube!";
    }
}
