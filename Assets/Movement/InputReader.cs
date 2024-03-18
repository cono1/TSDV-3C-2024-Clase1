using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace movement
{
    public class InputReader : MonoBehaviour
    {
        public CharacterMovement characterMovement;

        public void HandleMoveInput(InputAction.CallbackContext context)
        {
            Vector2 moveInput = context.ReadValue<Vector2>();
            Vector3 moveDir = new Vector3(moveInput.x, 0, moveInput.y);

            if (characterMovement)
                characterMovement.Move(moveDir);
            else
                Debug.LogError($"{name}: {nameof(characterMovement)} is null");
        }
    }
}