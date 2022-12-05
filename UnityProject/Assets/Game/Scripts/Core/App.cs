using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class App
{
    public static Managers Managers;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    public static void Start()
    {
        Managers = new Managers();
        
        Managers.StartNarrativeManager();
        Managers.StartInputManager();
        
        Debug.Log("Managers Initialised");
    }
}
