using UnityEngine;

public class Weapon : MonoBehaviour
{
  [Tooltip("Reference to fire point")]
  public Transform firePoint; // Position to fire bullet from
  [Tooltip("Reference to bullet prefab")]
  public GameObject bulletPrefab; // Bullet object to summon

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.E)) // Fire when player presses E
    {
      Shoot();
    }
  }

  void Shoot()
  {
    // Shooting logic
    Debug.Log("Fire!");
    Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); // Create bullet object from prefab
  }
}