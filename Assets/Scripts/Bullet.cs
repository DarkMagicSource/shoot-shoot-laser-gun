using UnityEngine;
// using UnityEngine.Tilemaps;

public class Bullet : MonoBehaviour
{
  public float speed = 20f;
  public Rigidbody2D rb;

  public TilemapController tileCtl;
  // public Tilemap tilemap;
  // public Vector3 tilePos;

  // Start is called before the first frame update
  void Start()
  {
    rb.velocity = transform.right * speed;
  }

  void OnTriggerEnter2D(Collider2D collision)
  {
    Debug.Log("Inital Collision " + collision.name);
    // Debug.Log(collision.name);
    if (collision.name == "Tilemap_Boxes")
    {
      tileCtl.Collide();
      // code v1
      // // Debug.Log("Collision with non-player");
      // Debug.Log(collision.name);
      // Destroy(collision);
      // Destroy(gameObject);

      // code v2
      //tilePos = tilemap.WorldToCell(collision.gameObject.transform.position);
    }
  }

  void OnBecameInvisible()
  {
    Destroy(gameObject); // Remove bullet object when it leaves the screen
  }
}
