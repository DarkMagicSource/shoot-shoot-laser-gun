using System;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
  [Tooltip("Reference to fire point")]
  public Transform firePoint; // Position to fire bullet from
  [Tooltip("Reference to bullet prefab")]
  public GameObject bulletPrefab; // Bullet object to summon
  [Tooltip("Number to bullets in gun")]
  public Slider ammoBar;

  void Start()
  {
    ammoBar.maxValue = 200;
    ammoBar.value = ammoBar.maxValue;
  }

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0)) // Fire when player presses E
    {
      if (ammoBar.value >= 1)
      {
        // Shooting logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); // Create bullet object from prefab
        ammoBar.value--; // Reduce number of bullets left
      }
      else
      {
        Debug.Log("Out of Ammo...");
      }
    }
  }
}