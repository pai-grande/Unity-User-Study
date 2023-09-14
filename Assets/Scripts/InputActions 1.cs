//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/InputActions 1.inputactions
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

public partial class @InputActions1 : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions1()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions 1"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""dfb85894-e59d-4d3e-9350-9a1bf78433d6"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6add4cd7-280b-4c24-a843-3d247720bf9a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""5abc629c-f2cf-4f14-9209-ba0b8fe37d7f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Enter"",
                    ""type"": ""Button"",
                    ""id"": ""1ee62b93-6aa2-4749-975b-7b78284ce3a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f90c48b1-099c-450d-84b9-26da54f70146"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""62638838-6f1a-4cb5-bd3d-a83350e76ce7"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b9361594-f248-4d93-ba28-f0a3c98f19c5"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f07d7e31-b961-45a6-8b15-5bb577822984"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d37f9628-b9ea-477b-b5c1-b728dfb72e89"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""cc469a20-af1b-47cd-8f23-9523c5bc0683"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""29fe5ac5-1666-4ca9-ad7e-80aabe6cca0e"",
                    ""path"": ""<XInputController>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8d8d0414-5c86-463d-b7cf-b074e950e860"",
                    ""path"": ""<XInputController>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d8b4fd5a-7c47-4f81-898f-742f6efef267"",
                    ""path"": ""<XInputController>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""01feb58e-8fd7-4789-8039-c5fc4b7d8214"",
                    ""path"": ""<XInputController>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""87561018-a852-43b4-92e6-d068b2c9626c"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Inverted Pitch"",
            ""id"": ""ccf5e8e7-0803-4fbf-88de-025e52d64352"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""01578742-7da6-4a30-9acf-d03165e09117"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""049df6c2-9281-41a3-9a38-ffc1b98d7ff4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Enter"",
                    ""type"": ""Button"",
                    ""id"": ""f75e557f-d913-4c24-a17e-11d7a3498563"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""82df97af-4ad3-426d-b252-fa8185ff72dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""719fa3ac-9e1f-4390-8f09-c5f785d0e913"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""down"",
                    ""id"": ""510621ea-cf36-4487-966b-192c0c8dacc6"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5354c101-6ffc-4231-9018-ad19cfe74f50"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4419fa38-77a9-42f0-8f8d-39a45d7c7311"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d504ecef-6ddd-4d85-b461-640f95f5a845"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""db7596f8-db57-4fa7-bc8f-806d5a2ae868"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9cb60a3f-51a8-4287-a85a-33f54132c4ff"",
                    ""path"": ""<XInputController>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b33a6266-92cc-4e3b-96e7-d0f0c870393e"",
                    ""path"": ""<XInputController>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4178757e-c827-4d99-8586-7e7001f58740"",
                    ""path"": ""<XInputController>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fb3f6314-7cc4-4ca9-9208-6e0b072742f7"",
                    ""path"": ""<XInputController>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox One Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3d54a78c-b551-41b5-b85b-ff0a38dd9d02"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0fcc560b-9536-4921-8ac4-8ccc164e8407"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Xbox One Gamepad"",
            ""bindingGroup"": ""Xbox One Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Enter = m_Player.FindAction("Enter", throwIfNotFound: true);
        // Inverted Pitch
        m_InvertedPitch = asset.FindActionMap("Inverted Pitch", throwIfNotFound: true);
        m_InvertedPitch_Movement = m_InvertedPitch.FindAction("Movement", throwIfNotFound: true);
        m_InvertedPitch_Look = m_InvertedPitch.FindAction("Look", throwIfNotFound: true);
        m_InvertedPitch_Enter = m_InvertedPitch.FindAction("Enter", throwIfNotFound: true);
        m_InvertedPitch_Newaction = m_InvertedPitch.FindAction("New action", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Enter;
    public struct PlayerActions
    {
        private @InputActions1 m_Wrapper;
        public PlayerActions(@InputActions1 wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Enter => m_Wrapper.m_Player_Enter;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Enter.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnter;
                @Enter.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnter;
                @Enter.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnter;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Enter.started += instance.OnEnter;
                @Enter.performed += instance.OnEnter;
                @Enter.canceled += instance.OnEnter;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Inverted Pitch
    private readonly InputActionMap m_InvertedPitch;
    private IInvertedPitchActions m_InvertedPitchActionsCallbackInterface;
    private readonly InputAction m_InvertedPitch_Movement;
    private readonly InputAction m_InvertedPitch_Look;
    private readonly InputAction m_InvertedPitch_Enter;
    private readonly InputAction m_InvertedPitch_Newaction;
    public struct InvertedPitchActions
    {
        private @InputActions1 m_Wrapper;
        public InvertedPitchActions(@InputActions1 wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_InvertedPitch_Movement;
        public InputAction @Look => m_Wrapper.m_InvertedPitch_Look;
        public InputAction @Enter => m_Wrapper.m_InvertedPitch_Enter;
        public InputAction @Newaction => m_Wrapper.m_InvertedPitch_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_InvertedPitch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InvertedPitchActions set) { return set.Get(); }
        public void SetCallbacks(IInvertedPitchActions instance)
        {
            if (m_Wrapper.m_InvertedPitchActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_InvertedPitchActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_InvertedPitchActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_InvertedPitchActionsCallbackInterface.OnMovement;
                @Look.started -= m_Wrapper.m_InvertedPitchActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_InvertedPitchActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_InvertedPitchActionsCallbackInterface.OnLook;
                @Enter.started -= m_Wrapper.m_InvertedPitchActionsCallbackInterface.OnEnter;
                @Enter.performed -= m_Wrapper.m_InvertedPitchActionsCallbackInterface.OnEnter;
                @Enter.canceled -= m_Wrapper.m_InvertedPitchActionsCallbackInterface.OnEnter;
                @Newaction.started -= m_Wrapper.m_InvertedPitchActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_InvertedPitchActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_InvertedPitchActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_InvertedPitchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Enter.started += instance.OnEnter;
                @Enter.performed += instance.OnEnter;
                @Enter.canceled += instance.OnEnter;
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public InvertedPitchActions @InvertedPitch => new InvertedPitchActions(this);
    private int m_XboxOneGamepadSchemeIndex = -1;
    public InputControlScheme XboxOneGamepadScheme
    {
        get
        {
            if (m_XboxOneGamepadSchemeIndex == -1) m_XboxOneGamepadSchemeIndex = asset.FindControlSchemeIndex("Xbox One Gamepad");
            return asset.controlSchemes[m_XboxOneGamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnEnter(InputAction.CallbackContext context);
    }
    public interface IInvertedPitchActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnEnter(InputAction.CallbackContext context);
        void OnNewaction(InputAction.CallbackContext context);
    }
}
