using UnityEngine;
using UnityEngine.Tilemaps;

public class Bullet : MonoBehaviour
{
  public float speed = 20f;
  public Rigidbody2D rb;

  // Start is called before the first frame update
  void Start()
  {
    rb.velocity = transform.right * speed;
  }

  void OnTriggerEnter2D(Collider2D collision)
  {
    Debug.Log("Inital Collision " + collision.name);
    if (collision.name == "Tilemap_Boxes")
    {
      var map = collision.gameObject.GetComponent<Tilemap>();
      var tilePos = map.WorldToCell(transform.position);
      map.SetTile(tilePos, null);
      Destroy(gameObject);
    }
  }

  void OnBecameInvisible()
  {
    Destroy(gameObject); // Remove bullet object when it leaves the screen
  }
}