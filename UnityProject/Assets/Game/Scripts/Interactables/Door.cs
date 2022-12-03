using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class Door : BaseInteractable
{
    [SerializeField] private bool isLocked;
    [SerializeField] private Animator doorAnimator;

    private bool _isOpen;

    private void Awake()
    {
        _isOpen = false;
    }

    public override void OnInteract(PlayerHand _)
    {
        if (isLocked) return;
        _isOpen = !_isOpen;
        doorAnimator.SetBool("isOpen", _isOpen);
        Debug.Log($"This door is now {_isOpen}");
    }
}
