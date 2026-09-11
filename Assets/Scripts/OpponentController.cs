using UnityEngine;

public class OpponentController : MonoBehaviour
{
    public float speed = 15.0f;
    public float yBoundary = 4.0f;
    private Transform ballTransform;

    void Start()
    {
        ballTransform = GameObject.FindWithTag("Ball").transform;
    }

    void Update()
    {
        if (ballTransform.position.y > transform.position.y) {
            float newY = transform.position.y + (speed * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(newY, -yBoundary, yBoundary), transform.position.z);
        }
        else if (ballTransform.position.y < transform.position.y) {
            float newY = transform.position.y - (speed * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(newY, -yBoundary, yBoundary), transform.position.z);
        }
    }
}
