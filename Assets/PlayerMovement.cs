using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Animator playerAnim;

    private Vector3 moveDirection;

    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        // Initialize moveDirection as zero
        moveDirection = Vector3.zero;

        // Handle forward and backward movement
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            moveDirection = transform.forward;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            moveDirection = -transform.forward;
        }

        // Handle rotation for left and right keys
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Rotate(-90f);
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Rotate(90f);
        }

        // Move the player
        if (moveDirection != Vector3.zero)
        {
            transform.position += moveDirection * moveSpeed * Time.deltaTime;

            // Set walking animation
            playerAnim.SetBool("run", true);
        }
        else
        {
            // Stop walking animation
            playerAnim.SetBool("run", false);
        }
    }

    void Rotate(float angle)
    {
        // Rotate the player around the Y axis by the specified angle
        transform.Rotate(0, angle, 0);
    }
}
