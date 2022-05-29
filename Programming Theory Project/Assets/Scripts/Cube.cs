using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Config;

public class Cube : Shape
{
    void Start()
    {
        shapeColor = PreSet.ColorDict["Blue"];
        shapeName = "Cube";
    }

    public override void DisplayState()
    {
        stateText.text = "This is a " + shapeName + ".";
        stateText.color = shapeColor;

        base.DisplayState();
    }
}
