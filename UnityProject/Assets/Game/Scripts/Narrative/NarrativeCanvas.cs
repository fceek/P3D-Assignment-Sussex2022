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
    [SerializeField] private TMP_Text textTemplate;

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

    private void Update()
    {
        AutoScroll();
    }
}
