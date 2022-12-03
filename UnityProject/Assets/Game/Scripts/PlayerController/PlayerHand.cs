using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// Sort player hand logic
/// </summary>
public class PlayerHand : MonoBehaviour
{
    [Header("Bindings")]
    [SerializeField] private Transform itemParent;
    [SerializeField] private HandTooltip tooltip;
    [Space]
    [Header("Configurations")]
    [SerializeField] private float maxDistance = 20.0f;
    [SerializeField] private float interactionCooldown = 2.0f;
    [SerializeField] private float throwForce = 5.0f;

    public GameObject itemHolding;
    private Transform _parentCache;
    private float _lastInteractTime;

    public bool IsFree => itemHolding == null;

    private BaseInteractable CurrentLookAt
    {
        get => _currentLookAt;
        set
        {
            if (value != null)
            {
                _currentLookAt = value;
                tooltip.LookAtTooltip(_currentLookAt);
            }
            else if (_currentLookAt != null)
            {
                _currentLookAt = value;
                tooltip.LookAtTimeout();
            }
        }
    }

    private Camera _mainCamera;
    private BaseInteractable _currentLookAt;


    private void Start()
    {
        _mainCamera = Camera.main;
        _lastInteractTime = 0f;
    }

    private void FixedUpdate()
    {
        BaseInteractable target;
        if (GetInteractTarget(out target) && target.gameObject != itemHolding)
        {
            CurrentLookAt = target;
        }
        else
        {
            CurrentLookAt = null;
        }
    }

    public void Interact()
    {
        if (CurrentLookAt == null || Time.time - _lastInteractTime < interactionCooldown) return;
        
        //Debug.Log(Time.time);
        //Debug.Log(_lastInteractTime);
        
        _lastInteractTime = Time.time;

        if (!CurrentLookAt.isPickup)
        {
            TriggerInteractable();
            return;
        }

        if (IsFree)
        {
            PickUpItem();
        }
        else
        {
            tooltip.WarnHandFull();
        }

    }

    public void Throw()
    {
        if (IsFree)
        {
            tooltip.WarnHandEmpty();
            return;
        }

        ThrowItem();
    }

    #region Actions
    
    private void TriggerInteractable()
    {
        _currentLookAt.OnInteract(this);
    }           

    private void PickUpItem()
    {
        PickUpItem(_currentLookAt);
    }

    public void PickUpItem(BaseInteractable item)
    {
        item.OnPickUp();
        itemHolding = item.gameObject;
        _parentCache = itemHolding.transform.parent;
        itemHolding.transform.SetParent(itemParent);
        itemHolding.transform.position = itemParent.position;
        itemHolding.GetComponent<Rigidbody>().isKinematic = true;
        tooltip.ThrowTooltip(itemHolding.GetComponent<BaseInteractable>().nameText);
    }

    private void ThrowItem()
    {
        Rigidbody rb = itemHolding.GetComponent<Rigidbody>();
        itemHolding.transform.SetParent(_parentCache, true);
        rb.isKinematic = false;
        rb.AddForce(_mainCamera.transform.forward * throwForce, ForceMode.Impulse);
        itemHolding = null;
    }

    public void ReleaseItem()
    {
        itemHolding.transform.SetParent(_parentCache, true);
        itemHolding = null;
    }
    
    #endregion

    #region Util

    private bool GetInteractTarget(out BaseInteractable target)
    {
        target = null;
        
        RaycastHit hit;
        GameObject hitTarget;
        Transform camtransform = _mainCamera.transform;
        if (Physics.Raycast(camtransform.position, camtransform.forward, out hit, maxDistance))
        {
            hitTarget = hit.transform.gameObject;
            target = hitTarget.GetComponent<BaseInteractable>();
        }

        return target != null;
    }
    
    #endregion
}