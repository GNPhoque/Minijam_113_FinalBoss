//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/Tools/Inputs/PlayerInputs.inputactions
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

public partial class @PlayerInputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""UI"",
            ""id"": ""0ed93393-db65-4106-b1a7-0cc87d7c1e11"",
            ""actions"": [
                {
                    ""name"": ""UP"",
                    ""type"": ""Button"",
                    ""id"": ""06b94339-108b-4691-8fbf-2141217a1beb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DOWN"",
                    ""type"": ""Button"",
                    ""id"": ""72a4a135-a611-431e-9b21-ff7f7d0fccf9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CONFIRM"",
                    ""type"": ""Button"",
                    ""id"": ""228cd6bc-87a0-4350-9c01-d026d07dffd6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""657e0829-0e0d-4c99-82b5-3e366574b92c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UP"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63bd5c81-9f28-487d-9a44-bb99b603679f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UP"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e9b5f12-3049-4d1e-b954-5e68c66ed7f6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DOWN"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c16543b-8d2e-4403-8f54-f4f505f2620d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DOWN"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ccc6c1c-e081-40a2-a4a9-594d4900e5f9"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CONFIRM"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Attack"",
            ""id"": ""58daa756-491b-4561-be36-01ca82851a3b"",
            ""actions"": [
                {
                    ""name"": ""Melee"",
                    ""type"": ""Button"",
                    ""id"": ""dbb0a3ae-0b2c-41e8-8d64-e8d6b48836c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Magic"",
                    ""type"": ""Button"",
                    ""id"": ""2ae51ad7-5d31-4e8d-bf29-0b6b0fe3a4a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DEBUG_Heal"",
                    ""type"": ""Button"",
                    ""id"": ""85751918-fa5c-4c16-b188-e539b859c9d9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DEBUG_Damage"",
                    ""type"": ""Button"",
                    ""id"": ""edde4247-fefe-45ec-9b36-66bd41d46f23"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ae599b7e-1d00-4d5f-8b12-805a5f2de6e8"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5dec1687-279c-4a94-aa85-d0d46eff9f70"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Magic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1742a39d-fe34-4f33-b112-ec75c8efa5bf"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DEBUG_Heal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c638940-d40d-47a4-a5f0-cdc3efc57835"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DEBUG_Damage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Movement"",
            ""id"": ""c309ea8e-0cfe-4618-b4eb-908fb123246d"",
            ""actions"": [
                {
                    ""name"": ""Direction"",
                    ""type"": ""Value"",
                    ""id"": ""8944ebbe-3e9e-42a2-9c25-5618dc98bd18"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a1fa0ea0-6120-4bb6-9ffc-b50e9619d4f7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""9b397517-c7f8-4327-bb5f-471abb37cfc0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c4ad92e1-5fec-48d8-ba40-d16a230a1e29"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8ca98fed-6a24-4b7d-bdc6-cf954a64a9ab"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ceac1396-1eed-41e7-a9b5-289e802d910a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""648dc147-c5ae-4697-ad2d-d3202cdea9f0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ARROWS"",
                    ""id"": ""8909ccb0-f9d9-41db-a9fb-46f53a4ff17b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3ea59e39-c88d-4e37-9ca0-526959fdc4d3"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f10813be-f42e-4275-9e17-44f58b2832a6"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""572f6933-d972-4c86-b759-2ab979f92613"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e319136a-68a7-4282-8bcf-391316dd2605"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a54c2154-c9fb-418c-9e02-6087b98b61c5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_UP = m_UI.FindAction("UP", throwIfNotFound: true);
        m_UI_DOWN = m_UI.FindAction("DOWN", throwIfNotFound: true);
        m_UI_CONFIRM = m_UI.FindAction("CONFIRM", throwIfNotFound: true);
        // Attack
        m_Attack = asset.FindActionMap("Attack", throwIfNotFound: true);
        m_Attack_Melee = m_Attack.FindAction("Melee", throwIfNotFound: true);
        m_Attack_Magic = m_Attack.FindAction("Magic", throwIfNotFound: true);
        m_Attack_DEBUG_Heal = m_Attack.FindAction("DEBUG_Heal", throwIfNotFound: true);
        m_Attack_DEBUG_Damage = m_Attack.FindAction("DEBUG_Damage", throwIfNotFound: true);
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Direction = m_Movement.FindAction("Direction", throwIfNotFound: true);
        m_Movement_Jump = m_Movement.FindAction("Jump", throwIfNotFound: true);
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

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_UP;
    private readonly InputAction m_UI_DOWN;
    private readonly InputAction m_UI_CONFIRM;
    public struct UIActions
    {
        private @PlayerInputs m_Wrapper;
        public UIActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @UP => m_Wrapper.m_UI_UP;
        public InputAction @DOWN => m_Wrapper.m_UI_DOWN;
        public InputAction @CONFIRM => m_Wrapper.m_UI_CONFIRM;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @UP.started -= m_Wrapper.m_UIActionsCallbackInterface.OnUP;
                @UP.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnUP;
                @UP.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnUP;
                @DOWN.started -= m_Wrapper.m_UIActionsCallbackInterface.OnDOWN;
                @DOWN.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnDOWN;
                @DOWN.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnDOWN;
                @CONFIRM.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCONFIRM;
                @CONFIRM.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCONFIRM;
                @CONFIRM.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCONFIRM;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @UP.started += instance.OnUP;
                @UP.performed += instance.OnUP;
                @UP.canceled += instance.OnUP;
                @DOWN.started += instance.OnDOWN;
                @DOWN.performed += instance.OnDOWN;
                @DOWN.canceled += instance.OnDOWN;
                @CONFIRM.started += instance.OnCONFIRM;
                @CONFIRM.performed += instance.OnCONFIRM;
                @CONFIRM.canceled += instance.OnCONFIRM;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // Attack
    private readonly InputActionMap m_Attack;
    private IAttackActions m_AttackActionsCallbackInterface;
    private readonly InputAction m_Attack_Melee;
    private readonly InputAction m_Attack_Magic;
    private readonly InputAction m_Attack_DEBUG_Heal;
    private readonly InputAction m_Attack_DEBUG_Damage;
    public struct AttackActions
    {
        private @PlayerInputs m_Wrapper;
        public AttackActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Melee => m_Wrapper.m_Attack_Melee;
        public InputAction @Magic => m_Wrapper.m_Attack_Magic;
        public InputAction @DEBUG_Heal => m_Wrapper.m_Attack_DEBUG_Heal;
        public InputAction @DEBUG_Damage => m_Wrapper.m_Attack_DEBUG_Damage;
        public InputActionMap Get() { return m_Wrapper.m_Attack; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AttackActions set) { return set.Get(); }
        public void SetCallbacks(IAttackActions instance)
        {
            if (m_Wrapper.m_AttackActionsCallbackInterface != null)
            {
                @Melee.started -= m_Wrapper.m_AttackActionsCallbackInterface.OnMelee;
                @Melee.performed -= m_Wrapper.m_AttackActionsCallbackInterface.OnMelee;
                @Melee.canceled -= m_Wrapper.m_AttackActionsCallbackInterface.OnMelee;
                @Magic.started -= m_Wrapper.m_AttackActionsCallbackInterface.OnMagic;
                @Magic.performed -= m_Wrapper.m_AttackActionsCallbackInterface.OnMagic;
                @Magic.canceled -= m_Wrapper.m_AttackActionsCallbackInterface.OnMagic;
                @DEBUG_Heal.started -= m_Wrapper.m_AttackActionsCallbackInterface.OnDEBUG_Heal;
                @DEBUG_Heal.performed -= m_Wrapper.m_AttackActionsCallbackInterface.OnDEBUG_Heal;
                @DEBUG_Heal.canceled -= m_Wrapper.m_AttackActionsCallbackInterface.OnDEBUG_Heal;
                @DEBUG_Damage.started -= m_Wrapper.m_AttackActionsCallbackInterface.OnDEBUG_Damage;
                @DEBUG_Damage.performed -= m_Wrapper.m_AttackActionsCallbackInterface.OnDEBUG_Damage;
                @DEBUG_Damage.canceled -= m_Wrapper.m_AttackActionsCallbackInterface.OnDEBUG_Damage;
            }
            m_Wrapper.m_AttackActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Melee.started += instance.OnMelee;
                @Melee.performed += instance.OnMelee;
                @Melee.canceled += instance.OnMelee;
                @Magic.started += instance.OnMagic;
                @Magic.performed += instance.OnMagic;
                @Magic.canceled += instance.OnMagic;
                @DEBUG_Heal.started += instance.OnDEBUG_Heal;
                @DEBUG_Heal.performed += instance.OnDEBUG_Heal;
                @DEBUG_Heal.canceled += instance.OnDEBUG_Heal;
                @DEBUG_Damage.started += instance.OnDEBUG_Damage;
                @DEBUG_Damage.performed += instance.OnDEBUG_Damage;
                @DEBUG_Damage.canceled += instance.OnDEBUG_Damage;
            }
        }
    }
    public AttackActions @Attack => new AttackActions(this);

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Direction;
    private readonly InputAction m_Movement_Jump;
    public struct MovementActions
    {
        private @PlayerInputs m_Wrapper;
        public MovementActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Direction => m_Wrapper.m_Movement_Direction;
        public InputAction @Jump => m_Wrapper.m_Movement_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Direction.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnDirection;
                @Direction.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnDirection;
                @Direction.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnDirection;
                @Jump.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Direction.started += instance.OnDirection;
                @Direction.performed += instance.OnDirection;
                @Direction.canceled += instance.OnDirection;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    public interface IUIActions
    {
        void OnUP(InputAction.CallbackContext context);
        void OnDOWN(InputAction.CallbackContext context);
        void OnCONFIRM(InputAction.CallbackContext context);
    }
    public interface IAttackActions
    {
        void OnMelee(InputAction.CallbackContext context);
        void OnMagic(InputAction.CallbackContext context);
        void OnDEBUG_Heal(InputAction.CallbackContext context);
        void OnDEBUG_Damage(InputAction.CallbackContext context);
    }
    public interface IMovementActions
    {
        void OnDirection(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
