using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundInteractable : BaseInteractable
{
    [SerializeField] private GlobalAudioControl gac;
    [SerializeField] private AudioClip clip;
    [SerializeField] private float timeout;

    public override void OnInteract(PlayerHand hand)
    {
        gac.PlayFading(clip, timeout);
    }
}
