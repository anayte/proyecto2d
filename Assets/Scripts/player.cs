using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    private ground groundMover;
    private Vector2 moveInput;

    void Start()
    {
        groundMover = GetComponent<ground>();
    }

    // Update is called once per frame
    void Update()
    {
        groundMover.move(moveInput.x);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
        
    public void OnJump(InputAction.CallbackContext context)
    {
        groundMover.jump(context.action.triggered);
    }
}