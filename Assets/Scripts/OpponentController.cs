using UnityEngine;

public class OpponentController : MonoBehaviour
{
    private Rigidbody2D opponentRB;
    public float speed = 6.0f;
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

        if (ballTransform.position.x > 0) {
            float targetY = Mathf.Lerp(opponentRB.position.y, ballTransform.position.y, 0.08f);
            float clampedY = Mathf.Clamp(targetY, -yBoundary, yBoundary);
            opponentRB.MovePosition(new Vector2(opponentRB.position.x, clampedY));
        }
    }
}
