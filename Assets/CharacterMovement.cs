// File path: Assets/Scripts/CharacterMovement.cs

using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    // Speed variable for movement
    public float speed = 5.0f;

    void Update()
    {
        // Initialize movement direction
        Vector3 movement = Vector3.zero;

        // Check for arrow key inputs and set the movement direction
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement += transform.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movement -= transform.forward;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement -= transform.right;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement += transform.right;
        }

        // Normalize the movement direction and apply the speed
        movement = movement.normalized * speed * Time.deltaTime;

        // Move the character
        transform.Translate(movement, Space.World);
    }
}
