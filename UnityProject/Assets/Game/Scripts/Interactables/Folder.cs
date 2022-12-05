using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Folder : BaseInteractable
{
    public override void OnInteract(PlayerHand hand)
    {
        Narrative.ShowFolder();
        gameObject.SetActive(false);
    }
}
