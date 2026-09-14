using UnityEngine;

public class OpponentController : MonoBehaviour
{
    private Rigidbody2D opponentRB;
    public float speed = 15.0f;
    public float yBoundary = 4.0f;
    private Transform ballTransform;

    void Start()
    {
        ballTransform = GameObject.FindWithTag("Ball").transform;
        opponentRB = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (ballTransform == null) return;

        float targetY = Mathf.MoveTowards(opponentRB.position.y, ballTransform.position.y, speed * Time.fixedDeltaTime);
        float clampedY = Mathf.Clamp(targetY, -yBoundary, yBoundary);
        opponentRB.MovePosition(new Vector2(opponentRB.position.x, clampedY));
    }
}
