using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverSelect : MonoBehaviour
{
    private Material startMaterial;
    public Material changeMaterial;

    void OnMouseEnter()
    {
        startMaterial = GetComponent<Renderer>().material;
        GetComponent<Renderer>().material = changeMaterial;
    }
    void OnMouseExit()
    {
        GetComponent<Renderer>().material = startMaterial;
    }
}
