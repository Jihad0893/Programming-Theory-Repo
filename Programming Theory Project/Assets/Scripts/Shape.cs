using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    public GameObject statePanel;
    public Text stateText;

    private Color32 m_shapeColor;
    public Color shapeColor
    {
        get { return m_shapeColor; }
        set { m_shapeColor = value; }
    }

    private string m_shapeName;
    public string shapeName
    {
        get { return m_shapeName; }
        set { 
            if (value != null)
            {
                m_shapeName = value;
            }
        }
    }

    public virtual void DisplayState()
    {
        if (!statePanel.activeInHierarchy && stateText.text != null)
        {
            statePanel.SetActive(true);
        }
    }

    private void OnMouseOver()
    {
        DisplayState();
    }

    private void OnMouseExit()
    {
        statePanel.SetActive(false);
    }

}
