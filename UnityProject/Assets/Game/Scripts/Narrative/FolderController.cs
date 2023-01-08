using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class FolderController : MonoBehaviour
{
    [SerializeField] private List<Animator> pages;
    [SerializeField] private float cooldown = 2.0f;
    
    private int _currentPage;
    private NarrativeCanvas _narrative;
    private float _lastOperationTime;

    private void Start()
    {
        _currentPage = 0;
        _narrative = App.Managers.GetNarrativeManager().NarrativeCanvas;
        _narrative.AddNotification("He can flip the page with Right-Click.");

        _lastOperationTime = Time.time;
        CustomInputs inputs = App.Managers.GetInputManager().CustomInputs;
        inputs.Interactions.Proceed.performed += OnTurnPage;
    }

    private void OnTurnPage(InputAction.CallbackContext ctx)
    {
        if (Time.time <= _lastOperationTime + cooldown) return;
        if (_currentPage == 2)
        {
            LoadEnding();
            return;
        }
        pages[_currentPage].SetTrigger("TurnPage");
        pages[_currentPage + 1].gameObject.transform.SetAsLastSibling();
        _currentPage++;
        _lastOperationTime = Time.time;
    }

    private void LoadEnding()
    {
        Animator sceneFade = GameObject.FindGameObjectWithTag("SceneTransition").GetComponent<Animator>();
        sceneFade.SetTrigger("StartFade");
        StartCoroutine(LoadAfterFade());
    }

    private IEnumerator LoadAfterFade()
    {
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene("Ending", LoadSceneMode.Single);
    }
}
