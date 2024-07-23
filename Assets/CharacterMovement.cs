using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Move the character forward based on the direction it is facing
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MoveForward();
        }
        // Rotate the character to the left by 90 degrees and move in the new direction
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            RotateLeft();
        }
        // Rotate the character to the right by 90 degrees and move in the new direction
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RotateRight();
        }
        // Rotate the character by 180 degrees and move in the new direction
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Rotate180();
        }

        // Continuously move the character forward based on the direction it is facing
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            MoveForward();
        }
    }

    void MoveForward()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    void RotateLeft()
    {
        transform.Rotate(0, -90f, 0);
    }

    void RotateRight()
    {
        transform.Rotate(0, 90f, 0);
    }

    void Rotate180()
    {
        transform.Rotate(0, 180f, 0);
    }
}
