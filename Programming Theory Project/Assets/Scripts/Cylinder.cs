using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Config;

public class Cylinder : Shape
{
    void Start()
    {
        shapeColor = PreSet.ColorDict["Red"];
        shapeName = "Cylinder";
    }

    public override void DisplayState()
    {
        stateText.text = "This is a " + shapeName + ".";
        stateText.color = shapeColor;

        base.DisplayState();
    }
}
