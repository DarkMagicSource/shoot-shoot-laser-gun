using UnityEngine;

public class ShootDir : MonoBehaviour
{

  public Rigidbody2D rb;
  public GameObject player;
  public GameObject crosshair;
  public Camera cam;

  Vector2 mousePos;

  void Update()
  {
    mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
  }

  void FixedUpdate()
  {
    gameObject.transform.position = player.transform.position;
    crosshair.transform.position = mousePos;
    Vector2 lookDir = mousePos - rb.position;
    float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
    rb.rotation = angle;
  }
}