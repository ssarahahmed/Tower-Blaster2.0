using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("FallThrough"))
        {
           
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>(), true);

            // Deactivate the platform (make it disappear)
            //collision.gameObject.SetActive(false); // Disables the platform
        }
    }

}
