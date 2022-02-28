using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    CharacterControls input;

    Vector2 currentMovement;

    public PlayerController playerController;

    private int horizontal = 0, vertical = 0;

    public enum Axis
    {
        Horizontal,
        Vertical
    }
    void Awake()
    {
        playerController = GetComponent<PlayerController>();
    }
    public void OnMovement(InputValue value)
    {
        Vector2 V = value.Get<Vector2>();

        horizontal = (int)V.x;
        vertical = (int)V.y;
    }
    
    void Update()
    {

        GetKeyboardInput();

        SetMovement();
    }

    void GetKeyboardInput()
    {

        horizontal = GetAxisRaw(Axis.Horizontal);
        vertical = GetAxisRaw(Axis.Vertical);

        if(horizontal != 0)
        {
            vertical = 0;
        }
    }

    void SetMovement()
    {

        if(vertical != 0)
        {
            playerController.SetInputDirection((vertical == 1) ? PlayerDirection.UP : PlayerDirection.DOWN);
        }
        else if (horizontal != 0)
        {
            playerController.SetInputDirection((horizontal == 1) ? PlayerDirection.RIGHT : PlayerDirection.LEFT);
        }
    }

    int GetAxisRaw(Axis axis)
    {
        if (axis == Axis.Horizontal)
        {
            bool left = horizontal == 1;
            bool right = horizontal == -1;

            if(left)
            {
                return 1;
                
            }
            if(right)
            {
                return -1;
            }
            return 0;
        }
        else if (axis == Axis.Vertical)
        {
            bool up = vertical == 1;
            bool down = vertical == -1;

            if(up)
            {
                return 1;
            }
            if(down)
            {
                return -1;
            }
            return 0;

        }
        return 0;
    }
}
