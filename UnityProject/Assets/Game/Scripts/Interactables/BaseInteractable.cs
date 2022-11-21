using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Collider), typeof(Rigidbody))]
public class BaseInteractable : MonoBehaviour
{
    public bool isPickup;
    public string nameText;

    public virtual void Interact()
    {
        //DEBUG
        Debug.Log($"Interacted with {nameText}");
    }
}
