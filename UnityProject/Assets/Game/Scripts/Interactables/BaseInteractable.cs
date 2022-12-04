using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Collider), typeof(Rigidbody))]
public class BaseInteractable : MonoBehaviour
{
    public bool isPickup;
    public string nameText;

    protected static NarrativeCanvas Narrative;

    private void Start()
    {
        if (Narrative == null) Narrative = App.Managers.GetNarrativeManager().NarrativeCanvas;
    }

    public virtual void OnInteract(PlayerHand hand)
    {
        //DEBUG
        Debug.Log($"Interacted with {nameText}");
    }

    public virtual void OnPickUp()
    {
        //DEBUG
        Debug.Log($"Picked up {nameText}");
    }
}
