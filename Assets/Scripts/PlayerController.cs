using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    public float yBoundary = 4.0f;

    void Update()
    {
        float moveInput = Input.GetAxisRaw("Vertical");
        float newY = transform.position.y + (moveInput * speed * Time.deltaTime);

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(newY, -yBoundary, yBoundary), transform.position.z);
    }
}