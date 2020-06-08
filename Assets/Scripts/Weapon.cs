using UnityEngine;

public class Weapon : MonoBehaviour
{
  public Transform firePoint; // Position to fire bullet from
  public GameObject bulletPrefab; // Bullet object to summon

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.E))
    {
      Shoot();
    }
  }

  void Shoot()
  {
    // Shooting logic
    Debug.Log("Fire!");
    Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
  }
}