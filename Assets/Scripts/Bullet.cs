using UnityEngine;
using UnityEngine.Tilemaps;

public class Bullet : MonoBehaviour
{
  [Tooltip("How fast the bullet travels")]
  public float speed = 10f;
  private Rigidbody2D rb;
  [Tooltip("Impact effect prefab")]
  public GameObject impactEffect;

  void Start()
  {
    rb = gameObject.GetComponent<Rigidbody2D>();
    rb.velocity = transform.right * speed; // Propels bullet forward
  }


  void OnTriggerStay2D(Collider2D collision)
  {
    // Debug.Log("Inital Collision " + collision.name);
    if (collision.name == "Tilemap_Boxes") // Test if bullet is hitting boxes tilemap layer
    {
      Instantiate(impactEffect, transform.position, transform.rotation);
      var map = collision.gameObject.GetComponent<Tilemap>(); // Get tilemap component from collided object
      var tilePos = map.WorldToCell(transform.position); // Get position of tile hit
      Debug.Log("Tile hit: " + tilePos);
      map.SetTile(tilePos, null); // Remove said tile
      Destroy(gameObject); // Remove bullet
    }
  }

  void OnBecameInvisible()
  {
    Destroy(gameObject); // Remove bullet object when it leaves the screen
  }
}