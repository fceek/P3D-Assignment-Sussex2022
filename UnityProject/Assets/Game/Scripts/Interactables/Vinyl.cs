using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vinyl : BaseInteractable
{
    [SerializeField] private AudioClip audioClip;
    private static int _counter = 0;

    public override void OnPickUp()
    {
        NarrativeCanvas nar = App.Managers.GetNarrativeManager().NarrativeCanvas;
        _counter++;
        switch (_counter)
        {
            case 1:
                nar.AddNarrative("\"They should be put back to the shelf, aligned.\" He thinks.");
                break;
            case 2:
                nar.AddNarrative("He wonders what's recorded inside the vinyl. The player might help.");
                break;
            case 3:
                nar.AddNarrative("Take the vinyl out... THROW the vinyl out...");
                break;
            default:
                nar.AddNarrative($"He picks up a vinyl of {audioClip.name}");
                break;
        }
    }
}
