using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrativeManager : MonoBehaviour
{
    private NarrativeCanvas _narrativeCanvas;
    public NarrativeCanvas NarrativeCanvas {
        get
        {
            if (_narrativeCanvas == null)
            {
                _narrativeCanvas = GameObject.FindGameObjectWithTag("NarrativeCanvas").GetComponent<NarrativeCanvas>();
            }

            return _narrativeCanvas;
        }
    }
}
