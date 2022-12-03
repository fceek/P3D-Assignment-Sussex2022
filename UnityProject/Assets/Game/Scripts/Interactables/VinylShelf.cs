using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class VinylShelf : BaseInteractable
{
    [SerializeField] private List<Vinyl> vinyls;
    [SerializeField] private List<GameObject> vinylsOnShelf;

    private int top;
    private NarrativeCanvas nar;

    private void Awake()
    {
        top = 0;
    }

    private void Start()
    {
        nar = App.Managers.GetNarrativeManager().NarrativeCanvas;
    }

    public override void OnInteract(PlayerHand hand)
    {
        if (hand.IsFree)
        {
            TryTakeVinyl(hand);
            return;
        }
        
        if (hand.itemHolding.TryGetComponent(out Vinyl _))
        {
            PutVinyl(hand);
        }
    }

    private void TryTakeVinyl(PlayerHand hand)
    {
        if (top == 0) return;
        top--;
        vinylsOnShelf[top].gameObject.SetActive(false);
        vinyls[top].gameObject.SetActive(true);
        hand.PickUpItem(vinyls[top]);
    }

    private void PutVinyl(PlayerHand hand)
    {
        if (top == vinylsOnShelf.Count) return;
        vinyls[top] = hand.itemHolding.GetComponent<Vinyl>();
        hand.ReleaseItem();
        vinyls[top].gameObject.SetActive(false);
        vinylsOnShelf[top].gameObject.SetActive(true);
        top++;
    }
}
