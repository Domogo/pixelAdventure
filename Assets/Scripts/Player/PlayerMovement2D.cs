using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour 
{ 
    public CharacterController2D controller;
    public float runSpeed = 80f;

    private readonly string HORIZONTAL_AXIS = "Horizontal";
    private float horizontalMove = 0f;
    private bool isPlayerJumping;

    // Update is called once per frame
    void Update() 
    {
        horizontalMove = Input.GetAxisRaw(HORIZONTAL_AXIS) * runSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            isPlayerJumping = true;
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, isPlayerJumping);
        isPlayerJumping = false;
    }
}
