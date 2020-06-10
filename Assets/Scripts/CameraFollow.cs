using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  [Tooltip("Reference to player object")]
  public Transform target; // Reference to player object

  [Tooltip("Level of smoothing for camera movement")]
  public float smoothSpeed = 0.125f;
  [Tooltip("X, Y, Z offset for camera position")]
  public Vector3 offset;

  void FixedUpdate()
  {
    Vector3 desieredPosition = target.position + offset;
    Vector3 smoothedPosition = Vector3.Lerp(transform.position, desieredPosition, smoothSpeed);
    transform.position = smoothedPosition;
  }
}