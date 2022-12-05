using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public CustomInputs CustomInputs;

    private void Awake()
    {
        CustomInputs = new CustomInputs();
        CustomInputs.Enable();
    }
}
