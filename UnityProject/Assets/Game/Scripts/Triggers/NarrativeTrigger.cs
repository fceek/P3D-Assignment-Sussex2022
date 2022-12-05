using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrativeTrigger : MonoBehaviour
{
    private NarrativeCanvas _narrative;
    [TextArea]
    [SerializeField] private string text;
    [SerializeField] private bool repeated;

    private void Start()
    {
        _narrative = App.Managers.GetNarrativeManager().NarrativeCanvas;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _narrative.AddNarrative(text);
            if (!repeated) Destroy(gameObject);
        }
    }
}
