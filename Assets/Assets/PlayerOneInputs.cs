// GENERATED AUTOMATICALLY FROM 'Assets/PlayerOneInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;
using UnityEngine.Experimental.Input.Utilities;

public class PlayerOneInputs : IInputActionCollection
{
    private InputActionAsset asset;
    public PlayerOneInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerOneInputs"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""310319e3-5f2e-4c66-abde-970d4c292c87"",
            ""actions"": [
                {
                    ""name"": ""Axis"",
                    ""id"": ""f2ee9238-d55f-437f-83f1-70f4dd0d0cbe"",
                    ""expectedControlLayout"": ""Axis"",
                    ""continuous"": true,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""51f3b5d3-0fcb-4da4-b70f-0d717925c5f4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c3592651-4dbc-4cbc-a8e3-51f9ea5b870c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";KeyBoard"",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""down"",
                    ""id"": ""860ba449-4950-4583-af01-3d15cd3d2949"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";KeyBoard"",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""left"",
                    ""id"": ""071cb4b8-9ab8-43a5-ad01-2b27d7dd3dbd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";KeyBoard"",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d190fb6f-11df-416d-99c3-d0e9376232d7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";KeyBoard"",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""258998e8-44e7-4c97-a0db-18589855a303"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""up"",
                    ""id"": ""53e1cc15-309f-4634-a19f-7c230f58dbde"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XBOXController"",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""down"",
                    ""id"": ""48fcb9ac-3fe1-4fd9-a749-ed74b692794a"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XBOXController"",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8e49c90a-d1c6-4464-ab7c-644951fd4b2c"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XBOXController"",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ddca231f-f895-4d74-8987-910d26f08cb5"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XBOXController"",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                }
            ]
        },
        {
            ""name"": ""Actions"",
            ""id"": ""8c3ca6a8-c96a-4ca7-b396-657362806817"",
            ""actions"": [
                {
                    ""name"": ""Hit"",
                    ""id"": ""3aca2b2a-c155-4947-ab50-5d04fe2dc257"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""68f05fe0-4565-4d36-adc7-dbdaf5b8238b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";KeyBoard"",
                    ""action"": ""Hit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""4cb541ab-1fb3-47e5-b90d-d4c2c8158aae"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XBOXController"",
                    ""action"": ""Hit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyBoard"",
            ""basedOn"": """",
            ""bindingGroup"": ""KeyBoard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XBOXController"",
            ""basedOn"": """",
            ""bindingGroup"": ""XBOXController"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Movement
        m_Movement = asset.GetActionMap("Movement");
        m_Movement_Axis = m_Movement.GetAction("Axis");
        // Actions
        m_Actions = asset.GetActionMap("Actions");
        m_Actions_Hit = m_Actions.GetAction("Hit");
    }
    ~PlayerOneInputs()
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
    public ReadOnlyArray<InputControlScheme> controlSchemes
    {
        get => asset.controlSchemes;
    }
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
    // Movement
    private InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private InputAction m_Movement_Axis;
    public struct MovementActions
    {
        private PlayerOneInputs m_Wrapper;
        public MovementActions(PlayerOneInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Axis { get { return m_Wrapper.m_Movement_Axis; } }
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                Axis.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnAxis;
                Axis.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnAxis;
                Axis.cancelled -= m_Wrapper.m_MovementActionsCallbackInterface.OnAxis;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                Axis.started += instance.OnAxis;
                Axis.performed += instance.OnAxis;
                Axis.cancelled += instance.OnAxis;
            }
        }
    }
    public MovementActions @Movement
    {
        get
        {
            return new MovementActions(this);
        }
    }
    // Actions
    private InputActionMap m_Actions;
    private IActionsActions m_ActionsActionsCallbackInterface;
    private InputAction m_Actions_Hit;
    public struct ActionsActions
    {
        private PlayerOneInputs m_Wrapper;
        public ActionsActions(PlayerOneInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Hit { get { return m_Wrapper.m_Actions_Hit; } }
        public InputActionMap Get() { return m_Wrapper.m_Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(ActionsActions set) { return set.Get(); }
        public void SetCallbacks(IActionsActions instance)
        {
            if (m_Wrapper.m_ActionsActionsCallbackInterface != null)
            {
                Hit.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnHit;
                Hit.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnHit;
                Hit.cancelled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnHit;
            }
            m_Wrapper.m_ActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                Hit.started += instance.OnHit;
                Hit.performed += instance.OnHit;
                Hit.cancelled += instance.OnHit;
            }
        }
    }
    public ActionsActions @Actions
    {
        get
        {
            return new ActionsActions(this);
        }
    }
    private int m_KeyBoardSchemeIndex = -1;
    public InputControlScheme KeyBoardScheme
    {
        get
        {
            if (m_KeyBoardSchemeIndex == -1) m_KeyBoardSchemeIndex = asset.GetControlSchemeIndex("KeyBoard");
            return asset.controlSchemes[m_KeyBoardSchemeIndex];
        }
    }
    private int m_XBOXControllerSchemeIndex = -1;
    public InputControlScheme XBOXControllerScheme
    {
        get
        {
            if (m_XBOXControllerSchemeIndex == -1) m_XBOXControllerSchemeIndex = asset.GetControlSchemeIndex("XBOXController");
            return asset.controlSchemes[m_XBOXControllerSchemeIndex];
        }
    }
    public interface IMovementActions
    {
        void OnAxis(InputAction.CallbackContext context);
    }
    public interface IActionsActions
    {
        void OnHit(InputAction.CallbackContext context);
    }
}
