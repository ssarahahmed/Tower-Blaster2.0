using UnityEngine;

public class CameraBehavior: MonoBehaviour
{
    public Transform ball; // Drag your ball here
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desiredPosition = new Vector3(transform.position.x, ball.position.y + offset.y, transform.position.z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
