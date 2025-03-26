using UnityEngine;

public class RotateBase : MonoBehaviour
{ 
    public float rotationSpeed = 100f; // Speed at which the base rotates

    void Update()
    {
        // Rotate left when the left arrow key is pressed
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime); // Rotate around the Y-axis
        }

        // Rotate right when the right arrow key is pressed
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime); // Rotate around the Y-axis
        }
    }
}
