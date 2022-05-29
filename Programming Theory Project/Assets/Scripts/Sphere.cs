using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Config;

public class Sphere : Shape
{
    void Start()
    {
        shapeColor = PreSet.ColorDict["Black"];
        shapeName = "Sphere";
    }

    public override void DisplayState()
    {
        stateText.text = "This is a " + shapeName + ".";
        stateText.color = shapeColor;

        base.DisplayState();
    }
}
