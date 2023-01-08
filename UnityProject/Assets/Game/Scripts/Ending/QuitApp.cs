using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class QuitApp : MonoBehaviour
{
    public void OnQuitPressed(InputAction.CallbackContext ctx)
    {
        Application.Quit();
    }
}
