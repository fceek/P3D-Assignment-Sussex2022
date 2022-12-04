using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VinylToParticle : MonoBehaviour
{
    [SerializeField] private GameObject particle;
    [SerializeField] private GlobalAudioControl globalAudioCtrl;

    private NarrativeCanvas _narrative;

    private void Start()
    {
        _narrative = App.Managers.GetNarrativeManager().NarrativeCanvas;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Vinyl vinyl))
        {
            VisualEffect ve = Instantiate(particle, other.transform.position, other.transform.rotation).GetComponent<VisualEffect>();
            _narrative.AddNarrative("The music just fade away like the vinyl. He wonders if some time he will, too.");
            globalAudioCtrl.PlayFading(vinyl.audioClip, 6.0f);
            Destroy(other.gameObject);
        }
    }
}
