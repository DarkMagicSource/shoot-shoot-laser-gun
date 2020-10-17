using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
  public CharacterController2D controller; // Import movement controller

  [Tooltip("Player run speed")]
  public float runSpeed = 40f; // Player run speed
  float horizontalMove = 0f; // Create variable for horizontal player movement
  bool jump = false; // Create variable for jump
  private Rigidbody2D player;

  public Slider energyBar;

  void Start()
  {
    player = GetComponent<Rigidbody2D>();

    energyBar.maxValue = 100;
    energyBar.value = energyBar.maxValue;
  }

  void Update()
  {
    horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

    if (Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.W))
    {
      if (energyBar.value >= 60)
      {
        jump = true;
        energyBar.value = energyBar.value - 60;
      }
      else
      {
        Debug.Log("Pleae wait for your jump to recharge...");
      }
    }

    energyBar.value = energyBar.value + 0.1f;

    /* Vector2 vel = player.velocity;
    while (vel.magnitude == 0)
    {
      Debug.Log("Not moving");
    } */
  }

  void FixedUpdate()
  {
    // Move our character
    controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
    jump = false;
  }
}