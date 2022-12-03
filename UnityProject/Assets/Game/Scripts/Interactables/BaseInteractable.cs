using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Collider), typeof(Rigidbody))]
public class BaseInteractable : MonoBehaviour
{
    public bool isPickup;
    public string nameText;

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
