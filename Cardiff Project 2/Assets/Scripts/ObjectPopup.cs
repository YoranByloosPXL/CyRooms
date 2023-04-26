using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPopup : MonoBehaviour
{
    public GameObject gameObject;

    private void Update()
    {

    }

    private void OnMouseDown()
    {
        gameObject.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }
}
