using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorControler : MonoBehaviour
{
    public void onButtonPress(){
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
