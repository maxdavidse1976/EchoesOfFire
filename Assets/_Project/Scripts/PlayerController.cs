using UnityEngine;
using UnityEngine.InputSystem;

namespace DragonspiritGames.EchoesOfFire
{
    [CreateAssetMenu(fileName = "PlayerController", menuName = "InputController/PlayerController")]
    public class PlayerController : InputController
    {
        PlayerInput _inputActions;
        bool _isJumping;
        bool _isBreathingFire;

        void OnEnable()
        {
            _inputActions = new PlayerInput();
            _inputActions.Player.Enable();
            _inputActions.Player.Jump.started += JumpStarted;
            _inputActions.Player.Jump.canceled += JumpCanceled;
            _inputActions.Player.Fire.started += FireStarted;
            _inputActions.Player.Fire.canceled += FireCancelled;
        }

        void OnDisable()
        {
            _inputActions.Player.Disable();
            _inputActions.Player.Jump.started -= JumpStarted;
            _inputActions.Player.Jump.canceled -= JumpCanceled;
            _inputActions.Player.Fire.started -= FireStarted;
            _inputActions.Player.Fire.canceled -= FireCancelled;
            _inputActions = null;
        }

        void JumpStarted(InputAction.CallbackContext context)
        {
            _isJumping = true;
        }

        void JumpCanceled(InputAction.CallbackContext context)
        {
            _isJumping = false;
        }

        void FireStarted(InputAction.CallbackContext context)
        {
            _isBreathingFire = true;
        }

        void FireCancelled(InputAction.CallbackContext context)
        {
            _isBreathingFire = false;
        }

        public override bool RetrieveJumpInput(GameObject gameObject)
        {
            return _isJumping;
        }

        public override bool RetrieveFireInput(GameObject gameObject)
        {
            return _isBreathingFire;
        }

        public override float RetrieveMoveInput(GameObject gameObject)
        {
            return _inputActions.Player.Move.ReadValue<Vector2>().x;
        }
    }

}
