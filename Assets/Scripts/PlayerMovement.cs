using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    #region variables
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float speed = 7f;

    private PlayerInput input;
    private Vector2 moveVector = Vector2.zero;
    private bool isAttacking = false;

    #endregion

    private void Awake()
    {
        input = new PlayerInput();
    }


    private void OnEnable()
    {
        input.Enable();
        input.Player.Move.performed += OnMove;
        input.Player.Attack.performed += OnClickFire;

        input.Player.Move.canceled += OnCancelMove;
        input.Player.Attack.canceled += OnCancelFire;
    }

    private void OnDisable()
    {
        input.Disable();
        input.Player.Move.performed -= OnMove;
        input.Player.Attack.performed -= OnClickFire;

        input.Player.Move.canceled -= OnCancelMove;
        input.Player.Move.canceled -= OnCancelFire;

    }

    private void FixedUpdate()
    {
        MovePlayer();
        Debug.Log("Attack State: " + isAttacking);
        if (isAttacking ) 
        { 
            Attack();
        }
    }

    private void MovePlayer()
    {
        rigidbody2D.velocity = moveVector * speed;
    }

    private void Attack()
    {

    }

    private void OnMove(InputAction.CallbackContext value)
    {
        moveVector = value.ReadValue<Vector2>();
    }

    private void OnCancelMove(InputAction.CallbackContext value)
    {
        moveVector = Vector2.zero;
    }

    private void OnClickFire(InputAction.CallbackContext value)
    {
        isAttacking = true;
    }    
    private void OnCancelFire(InputAction.CallbackContext value)
    {
        isAttacking = false;
    }

}
