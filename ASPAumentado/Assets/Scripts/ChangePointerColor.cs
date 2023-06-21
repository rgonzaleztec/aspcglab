using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePointerColor : MonoBehaviour
{
    public GameObject pointer;

    public void changecolor(Color color)
    {
        this.pointer.GetComponent<Renderer>().material.SetColor("_Color", color);
    }
}
