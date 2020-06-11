using UnityEngine;

public class Weapon : MonoBehaviour
{
  [Tooltip("Reference to fire point")]
  public Transform firePoint; // Position to fire bullet from
  [Tooltip("Reference to bullet prefab")]
  public GameObject bulletPrefab; // Bullet object to summon
  [Tooltip("Number to bullets in gun")]
  public int mag = 3; // Number of bullets

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.E)) // Fire when player presses E
    {
      if (mag >= 1)
      {
        // Shooting logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); // Create bullet object from prefab
        mag = mag - 1;
      }
      else
      {
        Debug.Log("get more ammo loser");
      }
    }
  }
}