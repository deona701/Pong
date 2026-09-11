using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody2D ballRB;
    public float directionVertical;
    public int directionHorizontal;

    void Start()
    {
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
}
