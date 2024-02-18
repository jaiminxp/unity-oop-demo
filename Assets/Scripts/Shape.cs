using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    [SerializeField]
    private Color m_Color;

    private string m_Name;
    public string ShapeName
    {
        // ENCAPSULATION
        get { return m_Name; }
        set
        {
            if (value.Length > 20)
            {
                Debug.LogError("Name cannot be longer than 20 chars.");
            }
            else
            {
                m_Name = value;
            }
        }
    }

    [SerializeField]
    protected Text textObject;

    public virtual void DisplayText()
    {
        // ABSTRACTION
        textObject.text = "I am a generic shape";
    }

    void OnMouseDown()
    {
        DisplayText();
    }

    void Start()
    {
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", m_Color);
    }
}
