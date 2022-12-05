using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NarrativeCanvas : MonoBehaviour
{
    [SerializeField] private ScrollRect storyScroller;
    [SerializeField] private TMP_Text notification;
    [SerializeField] private float notificationTimeout = 3.0f;
    [SerializeField] private TMP_Text textTemplate;
    [SerializeField] private Transform contentParent;

    [Header("UI Prefabs")] 
    [SerializeField]
    private GameObject folderPrefab;

    private float _timeToClear;
    private bool _cleared = true;
    
    private void AutoScroll()
    {
        storyScroller.verticalNormalizedPosition = 0.0f;
    }

    public void AddNarrative(string text)
    {
        if (!storyScroller.GameObject().activeSelf) storyScroller.GameObject().SetActive(true);
        TMP_Text entry = Instantiate(textTemplate, storyScroller.content);
        entry.text = text;
    }

    public void AddNotification(string text)
    {
        notification.transform.parent.gameObject.SetActive(true);
        notification.text = text;
        _cleared = false;
        _timeToClear = Time.time + notificationTimeout;
    }

    private void ClearNotification()
    {
        notification.text = string.Empty;
        notification.transform.parent.gameObject.SetActive(false);
        _cleared = true;
    }

    private void Update()
    {
        AutoScroll();
        if (!_cleared && Time.time >= _timeToClear) ClearNotification();
    }

    public void ShowFolder()
    {
        Instantiate(folderPrefab, contentParent);
    }
}
