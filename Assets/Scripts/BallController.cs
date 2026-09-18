using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody2D ballRB;
    public float directionVertical;
    public int directionHorizontal;

    public float acceleration = 0.3f;
    public float maxSpeed = 20.0f;

    public float xBoundary = 8.0f;


    void Start() {
        ballRB = GetComponent<Rigidbody2D>();
        directionVertical = Random.Range(-4.0f, 4.0f);
        directionHorizontal = Random.Range(0, 2);

        if (directionHorizontal == 0) {
            ballRB.linearVelocity = new Vector2(5f, directionVertical);
        }
        else {
            ballRB.linearVelocity = new Vector2(-5f, directionVertical);
        }
    }

    void FixedUpdate() {
        if (ballRB.linearVelocity.magnitude < maxSpeed && ballRB.linearVelocity.magnitude > 0) {
            ballRB.linearVelocity += ballRB.linearVelocity.normalized * acceleration * Time.fixedDeltaTime;
        }
    }
}
