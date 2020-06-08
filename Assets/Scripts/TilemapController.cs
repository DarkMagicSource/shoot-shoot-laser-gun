using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapController : MonoBehaviour
{
  void Update()
  {

    // int tileX = (int)bullet.tilePos.x;
    // int tileY = (int)bullet.tilePos.y;
    // int tileZ = (int)bullet.tilePos.z;

    // Tilemap tilemap = GetComponent<Tilemap>();
    // tilemap.SetTile(new Vector3Int(tileX, tileY, tileZ), null); // Remove tile at the bullet position


  }
  void OnCollisionEnter2D(Collision2D col)
  {
    Debug.Log("OnCollisionEnter2D " + col);
  }

  public void Collide()
  {
    Debug.Log("hit");
  }
}