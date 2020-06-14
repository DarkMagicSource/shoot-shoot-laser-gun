using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public CharacterController2D controller; // Import movement controller

  [Tooltip("Player run speed")]
  public float runSpeed = 40f; // Player run speed
  float horizontalMove = 0f; // Create variable for horizontal player movement
  bool jump = false; // Create variable for jump
  private Rigidbody2D player;

  void Start()
  {
    player = GetComponent<Rigidbody2D>();
  }

  void Update()
  {
    horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

    if (Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.W))
    {
      jump = true;
    }

    // Vector2 vel = player.velocity;
    // while (vel.magnitude == 0)
    // {
    //   Debug.Log("Not moving");
    // }
  }

  void FixedUpdate()
  {
    // Move our character
    controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
    jump = false;
  }
}