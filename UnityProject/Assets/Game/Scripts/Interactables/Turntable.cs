using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turntable : BaseInteractable
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private GameObject vinylOnTurntable;
    [SerializeField] private Vinyl vinyl;

    public override void OnInteract(PlayerHand hand)
    {
        if (audioSource.isPlaying && hand.IsFree)
        {
            PickVinyl(hand);
            return;
        }
        
        if (!audioSource.isPlaying && !hand.IsFree && hand.itemHolding.TryGetComponent(out Vinyl _))
        {
            PutVinyl(hand);
        }
    }

    private void PickVinyl(PlayerHand hand)
    {
        audioSource.Stop();
        vinylOnTurntable.SetActive(false);
        vinyl.gameObject.SetActive(true);
        hand.PickUpItem(vinyl);
    }

    private void PutVinyl(PlayerHand hand)
    {
        vinyl = hand.itemHolding.GetComponent<Vinyl>();
        hand.ReleaseItem();
        audioSource.clip = vinyl.audioClip;
        vinyl.gameObject.SetActive(false);
        vinylOnTurntable.gameObject.SetActive(true);
        Narrative.AddNarrative($"{vinyl.audioClip.name}, one of his favourite.");
        audioSource.Play();
    }
}
