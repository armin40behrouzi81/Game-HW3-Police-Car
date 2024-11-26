using UnityEngine;

public class CarMoveWithA : MonoBehaviour
{
    public float speed = 10f; // Speed of the car

    void Update()
    {
        // Check if the "A" key is pressed
        if (Input.GetKey(KeyCode.S))
        {
            // Move the car forward
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W))
            {
            // Move the car forward
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            // Move the car forward
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            // Move the car forward
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
