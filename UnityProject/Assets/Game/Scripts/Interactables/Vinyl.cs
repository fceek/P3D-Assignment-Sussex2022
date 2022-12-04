using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vinyl : BaseInteractable
{
    public AudioClip audioClip;
    private static int _counter = 0;

    public override void OnPickUp()
    {
        _counter++;
        switch (_counter)
        {
            case 1:
                Narrative.AddNarrative("\"They should be put back to the shelf, aligned.\" He thinks.");
                break;
            case 2:
                Narrative.AddNarrative("He wonders what's recorded inside the vinyl. The turntable might help.");
                break;
            case 3:
                Narrative.AddNarrative("Take the vinyl out... THROW the vinyl out...");
                break;
            default:
                Narrative.AddNarrative($"He picks up a vinyl of {audioClip.name}");
                break;
        }
    }
}
