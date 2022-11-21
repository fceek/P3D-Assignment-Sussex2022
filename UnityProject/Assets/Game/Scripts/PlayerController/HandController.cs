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
    
    private CustomInputs _customInputs;

    private void Start()
    {
        _customInputs = new CustomInputs();
        _customInputs.Enable();
        _customInputs.Interactions.Interact.performed += OnInteraction;
        _customInputs.Interactions.Throw.performed += OnThrow;
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