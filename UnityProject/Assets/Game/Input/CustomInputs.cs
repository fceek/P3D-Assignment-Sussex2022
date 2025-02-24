//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Game/Input/CustomInputs.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @CustomInputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CustomInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CustomInputs"",
    ""maps"": [
        {
            ""name"": ""Interactions"",
            ""id"": ""b869edba-d6ed-4243-848e-72df832a91eb"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""9069ad36-ce6d-4a36-a6ed-264f4370a0ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Throw"",
                    ""type"": ""Button"",
                    ""id"": ""49860aa6-4000-4f3e-8591-ce6be2c2a818"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Proceed"",
                    ""type"": ""Button"",
                    ""id"": ""2a6b3f8f-4221-4698-b02b-c934e66a863f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8231c094-85fb-4a88-903d-f06d6f95d155"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b9e89af-1fd3-4b42-a872-7f89c544931d"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""076f0b20-b1f8-4fb4-8d69-a69654f0e28e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Proceed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Quit"",
            ""id"": ""0f776113-e03d-451e-bdb6-917ed1f2230a"",
            ""actions"": [
                {
                    ""name"": ""QuitApp"",
                    ""type"": ""Button"",
                    ""id"": ""455a73f5-af70-46c8-ad73-2b3fb81eba50"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7296a783-0f60-4f2d-940c-2e70a66c939b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""QuitApp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Interactions
        m_Interactions = asset.FindActionMap("Interactions", throwIfNotFound: true);
        m_Interactions_Interact = m_Interactions.FindAction("Interact", throwIfNotFound: true);
        m_Interactions_Throw = m_Interactions.FindAction("Throw", throwIfNotFound: true);
        m_Interactions_Proceed = m_Interactions.FindAction("Proceed", throwIfNotFound: true);
        // Quit
        m_Quit = asset.FindActionMap("Quit", throwIfNotFound: true);
        m_Quit_QuitApp = m_Quit.FindAction("QuitApp", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Interactions
    private readonly InputActionMap m_Interactions;
    private IInteractionsActions m_InteractionsActionsCallbackInterface;
    private readonly InputAction m_Interactions_Interact;
    private readonly InputAction m_Interactions_Throw;
    private readonly InputAction m_Interactions_Proceed;
    public struct InteractionsActions
    {
        private @CustomInputs m_Wrapper;
        public InteractionsActions(@CustomInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_Interactions_Interact;
        public InputAction @Throw => m_Wrapper.m_Interactions_Throw;
        public InputAction @Proceed => m_Wrapper.m_Interactions_Proceed;
        public InputActionMap Get() { return m_Wrapper.m_Interactions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractionsActions set) { return set.Get(); }
        public void SetCallbacks(IInteractionsActions instance)
        {
            if (m_Wrapper.m_InteractionsActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnInteract;
                @Throw.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnThrow;
                @Throw.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnThrow;
                @Throw.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnThrow;
                @Proceed.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnProceed;
                @Proceed.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnProceed;
                @Proceed.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnProceed;
            }
            m_Wrapper.m_InteractionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Throw.started += instance.OnThrow;
                @Throw.performed += instance.OnThrow;
                @Throw.canceled += instance.OnThrow;
                @Proceed.started += instance.OnProceed;
                @Proceed.performed += instance.OnProceed;
                @Proceed.canceled += instance.OnProceed;
            }
        }
    }
    public InteractionsActions @Interactions => new InteractionsActions(this);

    // Quit
    private readonly InputActionMap m_Quit;
    private IQuitActions m_QuitActionsCallbackInterface;
    private readonly InputAction m_Quit_QuitApp;
    public struct QuitActions
    {
        private @CustomInputs m_Wrapper;
        public QuitActions(@CustomInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @QuitApp => m_Wrapper.m_Quit_QuitApp;
        public InputActionMap Get() { return m_Wrapper.m_Quit; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(QuitActions set) { return set.Get(); }
        public void SetCallbacks(IQuitActions instance)
        {
            if (m_Wrapper.m_QuitActionsCallbackInterface != null)
            {
                @QuitApp.started -= m_Wrapper.m_QuitActionsCallbackInterface.OnQuitApp;
                @QuitApp.performed -= m_Wrapper.m_QuitActionsCallbackInterface.OnQuitApp;
                @QuitApp.canceled -= m_Wrapper.m_QuitActionsCallbackInterface.OnQuitApp;
            }
            m_Wrapper.m_QuitActionsCallbackInterface = instance;
            if (instance != null)
            {
                @QuitApp.started += instance.OnQuitApp;
                @QuitApp.performed += instance.OnQuitApp;
                @QuitApp.canceled += instance.OnQuitApp;
            }
        }
    }
    public QuitActions @Quit => new QuitActions(this);
    public interface IInteractionsActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnThrow(InputAction.CallbackContext context);
        void OnProceed(InputAction.CallbackContext context);
    }
    public interface IQuitActions
    {
        void OnQuitApp(InputAction.CallbackContext context);
    }
}
