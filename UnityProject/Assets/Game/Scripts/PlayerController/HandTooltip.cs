using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// Display tooltip text as in-game UI
/// </summary>
public class HandTooltip : MonoBehaviour
{
    [Header("Bindings")]
    [SerializeField] private TMP_Text tooltipText;
    [SerializeField] private TMP_Text warningText;

    [Space] [Header("Configuration")] 
    [SerializeField] private float fadeOutTime = 2.0f;

    private Coroutine _timeout;
    private Coroutine _warningTimeout;

    private Coroutine Timeout
    {
        get => _timeout;
        set
        {
            if (_timeout != null)
            {
                StopCoroutine(_timeout);
            }
            _timeout = value;
        }
    }

    private Coroutine WarningTimeout
    {
        get => _warningTimeout;
        set
        {
            if (_warningTimeout != null)
            {
                StopCoroutine(_warningTimeout);
            }
            _warningTimeout = value;
        }
    }
    private WaitForSeconds _delay;

    private void Awake()
    {
        _delay = new WaitForSeconds(fadeOutTime);
    }

    private void Start()
    {
        ClearTooltip();
        ClearWarningTooltip();
    }

    public void LookAtTooltip(BaseInteractable target)
    {
        string interactionType;
        if (target.isPickup)
        {
            interactionType = "pick up";
        }
        else
        {
            interactionType = "use";
        }

        tooltipText.text = $"I can press E to {interactionType} {target.nameText}";
    }

    public void LookAtTimeout()
    {
        // Timeout = StartCoroutine(SetTimeout());
        
        ClearTooltip();
    }

    public void ThrowTooltip(string nameText)
    {
        warningText.text = $"I can press Q to throw {nameText}";
        Timeout = StartCoroutine(SetWarningTimeout());
    }
    public void WarnHandFull()
    {
        warningText.text = "My hand is full.";
        WarningTimeout = StartCoroutine(SetWarningTimeout());
    }

    public void WarnHandEmpty()
    {
        warningText.text = "My hand is empty.";
        WarningTimeout = StartCoroutine(SetWarningTimeout());
    }

    private void ClearTooltip()
    {
        tooltipText.text = string.Empty;
    }

    private void ClearWarningTooltip()
    {
        warningText.text = string.Empty;
    }

    private IEnumerator SetTimeout()
    {
        yield return _delay;
        ClearTooltip();
        _timeout = null;
    }

    private IEnumerator SetWarningTimeout()
    {
        yield return _delay;
        ClearWarningTooltip();
        _warningTimeout = null;
    }
}