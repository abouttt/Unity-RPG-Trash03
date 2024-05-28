//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input System/GameControls.inputactions
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

public partial class @GameControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""e2e1368c-5b71-461b-8dac-e4e0c64b15bc"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""5b21aeb9-9bbe-483b-a9b7-d35fb6451826"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""c5292323-2337-44ac-9eec-c00f0e0adff5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""b3e61329-662d-46b1-8a1a-347b8a16fc80"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""4eda7952-ea23-42f5-b23b-51d80641ec41"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LockOn"",
                    ""type"": ""Button"",
                    ""id"": ""57d227c8-6cd4-4374-850c-af1631587432"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CursorToggle"",
                    ""type"": ""Button"",
                    ""id"": ""393c3e80-6fbf-4284-ba71-0b7d8820f316"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ItemInventory"",
                    ""type"": ""Button"",
                    ""id"": ""47952ea0-8fa6-44a6-84f9-0d726741bf27"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""EquipmentInventory"",
                    ""type"": ""Button"",
                    ""id"": ""3f5e7f20-87d8-4442-88fe-404cfde3231a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Quick"",
                    ""type"": ""Button"",
                    ""id"": ""c7f5e677-cfbc-4f6e-8000-96c59bad70bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""41b87a42-c71d-4cf9-b5cb-569767b1dcb7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""374e654b-6c1b-4720-8da6-1d33d6c18b3d"",
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
                    ""id"": ""99d20673-1c7d-4d6d-9189-0ac47c1656ab"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6731a012-3a5f-45db-ac93-a406a8bec5b1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""871952c8-a48b-45ae-9bc2-4e62486d55a1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f812637a-7e75-42dd-a321-c44faa67b140"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""62b00e95-6304-4b54-90db-1de4f903cc1d"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4987c954-28ef-4e40-abab-5fd2df81828c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3d7211b-04b9-4254-8bae-fbe555b4c2b7"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertX=false),ScaleVector2(x=0.5,y=0.5)"",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24b5809b-e3a9-4d19-97e0-fc0db3d467dd"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""CursorToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3652dcbd-86e2-4a25-951b-b4075603346d"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""LockOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""791be477-63c4-46b4-90ce-a4f2e4006d22"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""ItemInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ef6e910-9e92-4cda-a279-a5b5e0dacd67"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e127e47f-09b4-4651-8a4d-7cb40524fdf0"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""EquipmentInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15f50fae-00f5-43c1-b02f-901a453d372b"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=0)"",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""Quick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f3d5d61-9235-486b-b2b2-d95b4a85bf3d"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": ""Scale"",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""Quick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eebc3c38-bd07-4800-8dd3-c7a31bb420a3"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=2)"",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""Quick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cecba839-84b1-4bac-be44-81ad9246afe6"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=3)"",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""Quick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b90beec-6fc5-4797-a788-2f4dc1564d23"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=4)"",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""Quick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84cc0332-6529-427d-9c5e-793eff97762d"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=5)"",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""Quick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fcfe29d9-e036-4bd9-962e-9a2f523ac02b"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=6)"",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""Quick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8216135-52b5-43a7-a46f-07fcc99b18da"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=7)"",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""Quick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6899897-7213-4520-acfd-8873110fdcb5"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=8)"",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""Quick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5ade947-7a64-41cc-98fc-0986bafdbc52"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=9)"",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""Quick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard/Mouse"",
            ""bindingGroup"": ""Keyboard/Mouse"",
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
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_LockOn = m_Player.FindAction("LockOn", throwIfNotFound: true);
        m_Player_CursorToggle = m_Player.FindAction("CursorToggle", throwIfNotFound: true);
        m_Player_ItemInventory = m_Player.FindAction("ItemInventory", throwIfNotFound: true);
        m_Player_EquipmentInventory = m_Player.FindAction("EquipmentInventory", throwIfNotFound: true);
        m_Player_Quick = m_Player.FindAction("Quick", throwIfNotFound: true);
        m_Player_Cancel = m_Player.FindAction("Cancel", throwIfNotFound: true);
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
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Sprint;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_LockOn;
    private readonly InputAction m_Player_CursorToggle;
    private readonly InputAction m_Player_ItemInventory;
    private readonly InputAction m_Player_EquipmentInventory;
    private readonly InputAction m_Player_Quick;
    private readonly InputAction m_Player_Cancel;
    public struct PlayerActions
    {
        private @GameControls m_Wrapper;
        public PlayerActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @LockOn => m_Wrapper.m_Player_LockOn;
        public InputAction @CursorToggle => m_Wrapper.m_Player_CursorToggle;
        public InputAction @ItemInventory => m_Wrapper.m_Player_ItemInventory;
        public InputAction @EquipmentInventory => m_Wrapper.m_Player_EquipmentInventory;
        public InputAction @Quick => m_Wrapper.m_Player_Quick;
        public InputAction @Cancel => m_Wrapper.m_Player_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @LockOn.started += instance.OnLockOn;
            @LockOn.performed += instance.OnLockOn;
            @LockOn.canceled += instance.OnLockOn;
            @CursorToggle.started += instance.OnCursorToggle;
            @CursorToggle.performed += instance.OnCursorToggle;
            @CursorToggle.canceled += instance.OnCursorToggle;
            @ItemInventory.started += instance.OnItemInventory;
            @ItemInventory.performed += instance.OnItemInventory;
            @ItemInventory.canceled += instance.OnItemInventory;
            @EquipmentInventory.started += instance.OnEquipmentInventory;
            @EquipmentInventory.performed += instance.OnEquipmentInventory;
            @EquipmentInventory.canceled += instance.OnEquipmentInventory;
            @Quick.started += instance.OnQuick;
            @Quick.performed += instance.OnQuick;
            @Quick.canceled += instance.OnQuick;
            @Cancel.started += instance.OnCancel;
            @Cancel.performed += instance.OnCancel;
            @Cancel.canceled += instance.OnCancel;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @LockOn.started -= instance.OnLockOn;
            @LockOn.performed -= instance.OnLockOn;
            @LockOn.canceled -= instance.OnLockOn;
            @CursorToggle.started -= instance.OnCursorToggle;
            @CursorToggle.performed -= instance.OnCursorToggle;
            @CursorToggle.canceled -= instance.OnCursorToggle;
            @ItemInventory.started -= instance.OnItemInventory;
            @ItemInventory.performed -= instance.OnItemInventory;
            @ItemInventory.canceled -= instance.OnItemInventory;
            @EquipmentInventory.started -= instance.OnEquipmentInventory;
            @EquipmentInventory.performed -= instance.OnEquipmentInventory;
            @EquipmentInventory.canceled -= instance.OnEquipmentInventory;
            @Quick.started -= instance.OnQuick;
            @Quick.performed -= instance.OnQuick;
            @Quick.canceled -= instance.OnQuick;
            @Cancel.started -= instance.OnCancel;
            @Cancel.performed -= instance.OnCancel;
            @Cancel.canceled -= instance.OnCancel;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard/Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLockOn(InputAction.CallbackContext context);
        void OnCursorToggle(InputAction.CallbackContext context);
        void OnItemInventory(InputAction.CallbackContext context);
        void OnEquipmentInventory(InputAction.CallbackContext context);
        void OnQuick(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
}
