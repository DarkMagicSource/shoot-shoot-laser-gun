﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public CharacterController2D controller;

  public float runSpeed = 40f;
  float horizontalMove = 0f;
  bool jump = false;

  void Update()
  {
    horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

    if (Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.W))
    {
      jump = true;
    }
  }

  void FixedUpdate()
  {
    // Move our character
    controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
    jump = false;
  }
}