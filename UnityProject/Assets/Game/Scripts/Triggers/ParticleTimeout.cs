using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class ParticleTimeout : MonoBehaviour
{
    [SerializeField] private float timeout;

    private void Start()
    {
        Invoke(nameof(StopSelf), timeout);
    }

    private void StopSelf()
    {
        gameObject.GetComponent<VisualEffect>().Stop();
    }
}
