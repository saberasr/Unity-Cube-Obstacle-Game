using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float dodgeSpeed = 500;
    private bool canMove = true; // Flag to control player movement

    void FixedUpdate()
    {
        if (canMove)
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

            if (Input.GetKey("d"))
            {
                rb.AddForce(dodgeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("a"))
            {
                rb.AddForce(-dodgeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            canMove = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
