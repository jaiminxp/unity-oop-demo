using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// INHERITANCE
public class Cylinder : Shape
{
    Cylinder()
    {
        ShapeName = "Linger";
    }

    // POLYMORPHISM
    public override void DisplayText()
    {
        // ABSTRACTION
        textObject.text = "I am a Cylinder!";
    }
}
