using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Managers
{
    public Managers()
    {
        Init();
    }

    private GameObject _managers;
    
    //Add managers here
    private NarrativeManager _narrativeManager;

    private void Init()
    {
        if (_managers == null)
        {
            _managers = new GameObject("Managers");
        }
    }

    public void StartNarrativeManager()
    {
        if (_managers.TryGetComponent<NarrativeManager>(out _)) return;
        
        GameObject temp = new GameObject("Narrative Manager");
        _narrativeManager = temp.AddComponent<NarrativeManager>();
        temp.transform.SetParent(_managers.transform);
    }

    public NarrativeManager GetNarrativeManager()
    {
        return _narrativeManager;
    }
}
