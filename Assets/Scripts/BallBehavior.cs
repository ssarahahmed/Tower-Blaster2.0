using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("FallThrough"))
        {
            Debug.Log("Ball fell through the platform!");
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>(), true);
        }
    }
}

