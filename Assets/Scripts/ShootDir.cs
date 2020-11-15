using UnityEngine;

public class ShootDir : MonoBehaviour
{

  // References to gameObjects
  public Rigidbody2D rb;
  public GameObject player;
  public GameObject crosshair;
  public Camera cam;

  // Internal mouse position variable
  private Vector2 mousePos;

  void Update()
  {
    mousePos = cam.ScreenToWorldPoint(Input.mousePosition); // Set mousePos variable to location of mouse in pixel space
  }

  void FixedUpdate()
  {
    gameObject.transform.position = player.transform.position; // Set firePoint position to be centered on player
    crosshair.transform.position = mousePos; // Set crosshair position to mouse position
    Vector2 lookDir = mousePos - rb.position; // Get direction to mouse position
    float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg; // Convert mouse position direction to angle
    rb.rotation = angle; // Set firePoint rotation to point towards mouse position
  }
}