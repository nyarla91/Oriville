//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Input/GameplayActions.inputactions
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

public partial class @GameplayActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameplayActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameplayActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""5fc8b0c1-056f-4cb3-a014-b121bf02fd49"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""d073dc10-d5af-448f-a475-ca0f50fc9e2e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dodge"",
                    ""type"": ""Button"",
                    ""id"": ""e3491520-ec64-4858-a4dc-6e402fe6445c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ThrowHook"",
                    ""type"": ""Button"",
                    ""id"": ""2bf0ef96-87bc-4b30-9374-7705e247a21e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Harpoon"",
                    ""type"": ""Button"",
                    ""id"": ""a399bda0-8978-4635-afb4-95a14723ada2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Net"",
                    ""type"": ""Button"",
                    ""id"": ""ec9c250f-2885-445f-a03c-dbb5683c80c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""d5881f0b-7642-4528-adf8-53db6c955739"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""74968e03-8905-4d09-8276-22cf4fd19f5b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22c4fe4b-fdb1-4f0a-bb9e-85acd96ecae3"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""daf3980c-0da0-47cd-bc46-1fb757a02874"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""44d360f4-cca2-44b1-b005-8b57f9603874"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d136b3c0-82ce-49b6-ad61-e52bc384fa72"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d4fbfb52-db99-4c44-8e81-306da2d7e984"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""01947d23-e6e0-4fcb-a162-0b5d87c503a6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""eb106605-e2be-401e-9989-981681f2fcde"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ThrowHook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6b6c318-6b1c-49fe-a8aa-b0434c0a0057"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ThrowHook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e5fb813-9727-4085-8e93-3441c05a01df"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""ThrowHook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1114728b-fd67-4c10-a7ce-18a77f6f1963"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41862865-0eb5-4919-972e-0442d9ca8f58"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c2997bf-9746-4b95-9478-7b4f88bc619c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04055ba9-a4ad-44ba-9cbe-a717c1ddf15a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Harpoon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f5ff5a4-fdd3-4c29-935d-6e6457dee686"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Harpoon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb262219-acbd-48db-b14e-358d2fbac6a7"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Harpoon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""badcd0e7-08d2-4cad-9408-6c53af9e1940"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""efc483d5-4cf7-48bc-90a8-c6ca90416e43"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8270f28e-7d7d-43b6-8609-00c0020caaed"",
                    ""path"": ""<DualShockGamepad>/touchpadButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a9bc944-351e-42eb-879c-e27bf87080b1"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03c18f35-0647-4d8c-8fcd-e15c5b6f6736"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Net"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12ba4dcf-26c4-4c32-a95a-90f936509914"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Net"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c9ab1d7-482d-47c9-8488-96f5e7262df3"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Net"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Aim"",
            ""id"": ""39f9593e-4e18-4f08-a2fa-339444d0cdf6"",
            ""actions"": [
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Value"",
                    ""id"": ""1edce87f-6e11-4fae-bbff-c258605eda02"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""DeltaCursor"",
                    ""type"": ""Value"",
                    ""id"": ""6285e9e2-d249-49a0-93f3-1abd07b7aa29"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ToggleAiming"",
                    ""type"": ""Button"",
                    ""id"": ""e94d8c9b-beda-46ff-ab46-0dc03866b0b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""09ba1e5e-e40e-41ec-b9cb-3b1f58a07e81"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""869b11ea-c997-4539-bdf7-5bb1b974bb56"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeltaCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52f96069-5f72-4612-8397-72488e7cf6b6"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""ToggleAiming"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2f49adc-57fe-496e-88b7-f95046930018"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleAiming"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardMouse"",
            ""bindingGroup"": ""KeyboardMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
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
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Dodge = m_Player.FindAction("Dodge", throwIfNotFound: true);
        m_Player_ThrowHook = m_Player.FindAction("ThrowHook", throwIfNotFound: true);
        m_Player_Harpoon = m_Player.FindAction("Harpoon", throwIfNotFound: true);
        m_Player_Net = m_Player.FindAction("Net", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
        // Aim
        m_Aim = asset.FindActionMap("Aim", throwIfNotFound: true);
        m_Aim_Mouse = m_Aim.FindAction("Mouse", throwIfNotFound: true);
        m_Aim_DeltaCursor = m_Aim.FindAction("DeltaCursor", throwIfNotFound: true);
        m_Aim_ToggleAiming = m_Aim.FindAction("ToggleAiming", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Dodge;
    private readonly InputAction m_Player_ThrowHook;
    private readonly InputAction m_Player_Harpoon;
    private readonly InputAction m_Player_Net;
    private readonly InputAction m_Player_Pause;
    public struct PlayerActions
    {
        private @GameplayActions m_Wrapper;
        public PlayerActions(@GameplayActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Dodge => m_Wrapper.m_Player_Dodge;
        public InputAction @ThrowHook => m_Wrapper.m_Player_ThrowHook;
        public InputAction @Harpoon => m_Wrapper.m_Player_Harpoon;
        public InputAction @Net => m_Wrapper.m_Player_Net;
        public InputAction @Pause => m_Wrapper.m_Player_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Dodge.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDodge;
                @Dodge.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDodge;
                @Dodge.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDodge;
                @ThrowHook.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrowHook;
                @ThrowHook.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrowHook;
                @ThrowHook.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrowHook;
                @Harpoon.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHarpoon;
                @Harpoon.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHarpoon;
                @Harpoon.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHarpoon;
                @Net.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNet;
                @Net.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNet;
                @Net.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNet;
                @Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Dodge.started += instance.OnDodge;
                @Dodge.performed += instance.OnDodge;
                @Dodge.canceled += instance.OnDodge;
                @ThrowHook.started += instance.OnThrowHook;
                @ThrowHook.performed += instance.OnThrowHook;
                @ThrowHook.canceled += instance.OnThrowHook;
                @Harpoon.started += instance.OnHarpoon;
                @Harpoon.performed += instance.OnHarpoon;
                @Harpoon.canceled += instance.OnHarpoon;
                @Net.started += instance.OnNet;
                @Net.performed += instance.OnNet;
                @Net.canceled += instance.OnNet;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Aim
    private readonly InputActionMap m_Aim;
    private IAimActions m_AimActionsCallbackInterface;
    private readonly InputAction m_Aim_Mouse;
    private readonly InputAction m_Aim_DeltaCursor;
    private readonly InputAction m_Aim_ToggleAiming;
    public struct AimActions
    {
        private @GameplayActions m_Wrapper;
        public AimActions(@GameplayActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Mouse => m_Wrapper.m_Aim_Mouse;
        public InputAction @DeltaCursor => m_Wrapper.m_Aim_DeltaCursor;
        public InputAction @ToggleAiming => m_Wrapper.m_Aim_ToggleAiming;
        public InputActionMap Get() { return m_Wrapper.m_Aim; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AimActions set) { return set.Get(); }
        public void SetCallbacks(IAimActions instance)
        {
            if (m_Wrapper.m_AimActionsCallbackInterface != null)
            {
                @Mouse.started -= m_Wrapper.m_AimActionsCallbackInterface.OnMouse;
                @Mouse.performed -= m_Wrapper.m_AimActionsCallbackInterface.OnMouse;
                @Mouse.canceled -= m_Wrapper.m_AimActionsCallbackInterface.OnMouse;
                @DeltaCursor.started -= m_Wrapper.m_AimActionsCallbackInterface.OnDeltaCursor;
                @DeltaCursor.performed -= m_Wrapper.m_AimActionsCallbackInterface.OnDeltaCursor;
                @DeltaCursor.canceled -= m_Wrapper.m_AimActionsCallbackInterface.OnDeltaCursor;
                @ToggleAiming.started -= m_Wrapper.m_AimActionsCallbackInterface.OnToggleAiming;
                @ToggleAiming.performed -= m_Wrapper.m_AimActionsCallbackInterface.OnToggleAiming;
                @ToggleAiming.canceled -= m_Wrapper.m_AimActionsCallbackInterface.OnToggleAiming;
            }
            m_Wrapper.m_AimActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
                @DeltaCursor.started += instance.OnDeltaCursor;
                @DeltaCursor.performed += instance.OnDeltaCursor;
                @DeltaCursor.canceled += instance.OnDeltaCursor;
                @ToggleAiming.started += instance.OnToggleAiming;
                @ToggleAiming.performed += instance.OnToggleAiming;
                @ToggleAiming.canceled += instance.OnToggleAiming;
            }
        }
    }
    public AimActions @Aim => new AimActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardMouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnDodge(InputAction.CallbackContext context);
        void OnThrowHook(InputAction.CallbackContext context);
        void OnHarpoon(InputAction.CallbackContext context);
        void OnNet(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IAimActions
    {
        void OnMouse(InputAction.CallbackContext context);
        void OnDeltaCursor(InputAction.CallbackContext context);
        void OnToggleAiming(InputAction.CallbackContext context);
    }
}