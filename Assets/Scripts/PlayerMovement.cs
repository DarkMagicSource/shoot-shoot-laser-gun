using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public CharacterController2D controller; // Import movement controller

  public float runSpeed = 40f; // Player run speed
  float horizontalMove = 0f; // Create variable for horizontal player movement
  bool jump = false; // Create variable for jump

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