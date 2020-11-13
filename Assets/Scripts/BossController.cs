using System.Collections;
using UnityEngine;
using Random = System.Random; // Force all randoms to use System.Random

public class BossController : MonoBehaviour
{
  public GameObject Player; // Reference to player object
  Random random = new Random(); // initialize random
  bool currentlyAttacking = false;

  void Update()
  {
    Vector3 playerPos = Player.transform.position;
    Vector3 bossPos = transform.position;
    float distance = Vector3.Distance(playerPos, bossPos);

    if (distance <= 5)
    {
      if (!currentlyAttacking)
      {
        StartCoroutine(CalculateAttack());
      }
    }
  }

  int GetAttackId()
  {
    return random.Next(1, 4); // get random value to be used as attack ID
  }

  int GetAttackCooldown()
  {
    return random.Next(5, 9); // get random value to be used as cooldown between attacks
  }

  IEnumerator CalculateAttack()
  {
    int AttackId = GetAttackId();
    int attackCooldown = GetAttackCooldown();
    currentlyAttacking = true;

    switch (AttackId)
    {
      case 1:
        Attack1();
        break;
      case 2:
        Attack2();
        break;
      case 3:
        Attack3();
        break;
    }

    Debug.Log("Attack Cooldown: " + attackCooldown + "s");
    yield return new WaitForSeconds(attackCooldown);

    currentlyAttacking = false;
  }

  void Attack1() {
    Debug.Log("Attack 1");
  }

  void Attack2() {
    Debug.Log("Attack 2");
  }

  void Attack3() {
    Debug.Log("Attack 3");
  }
}