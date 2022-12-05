using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Handle inputs, bind and dispatch events
/// </summary>
public class HandController : MonoBehaviour
{
    [SerializeField] private PlayerHand playerHand;
    

    private void Start()
    {
        CustomInputs inputs = App.Managers.GetInputManager().CustomInputs;
        inputs.Interactions.Interact.performed += OnInteraction;
        inputs.Interactions.Throw.performed += OnThrow;
    }

    private void OnInteraction(InputAction.CallbackContext ctx)
    {
        playerHand.Interact();
        
        //DEBUG
        //Debug.Log("HandController: Interact");
    }

    private void OnThrow(InputAction.CallbackContext ctx)
    {
        playerHand.Throw();
        
        //DEBUG
        //Debug.Log("HandController: Throw");
    }
}