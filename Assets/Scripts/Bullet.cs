using UnityEngine;
using UnityEngine.Tilemaps;

public class Bullet : MonoBehaviour
{
  public float speed = 10f;
  public Rigidbody2D rb;

  void Start()
  {
    rb.velocity = transform.right * speed; // Propels bullet forward
  }

  void OnTriggerEnter2D(Collider2D collision)
  {
    Debug.Log("Inital Collision " + collision.name);
    if (collision.name == "Tilemap_Boxes") // Test if bullet is hitting boxes tilemap layer
    {
      var map = collision.gameObject.GetComponent<Tilemap>(); // Get tilemap component from collided object
      var tilePos = map.WorldToCell(transform.position); // Get position of tile hit
      map.SetTile(tilePos, null); // Remove said tile
      Destroy(gameObject); // Remove bullet
    }
  }

  void OnBecameInvisible()
  {
    Destroy(gameObject); // Remove bullet object when it leaves the screen
  }
}