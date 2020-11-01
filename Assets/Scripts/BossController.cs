using UnityEngine;
using Random = System.Random;

public class BossController : MonoBehaviour
{
  Random random = new Random();

  int timeRemaining = -1;

  void Start()
  {
    Debug.Log("Script Start");
  }

  void Update()
  {
    if (timeRemaining == -1) timeRemaining = AttackCooldown();
    Debug.Log("Time Remaining: " + timeRemaining);
    if (timeRemaining < 1) Debug.Log("Attack type " + GetAttackId());
    else timeRemaining--;
  }

  int GetAttackId()
  {
    int attackId = random.Next(0, 3);
    return attackId;
  }

  int AttackCooldown()
  {
    int AttackCooldown = random.Next(1000, 3000);
    return AttackCooldown;
  }
}
