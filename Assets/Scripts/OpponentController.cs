using UnityEngine;

public class OpponentController : MonoBehaviour
{
    private Rigidbody2D opponentRB;
    public float lerpSpeed = 0.06f;
    public float yBoundary = 4.0f;
    private Transform ballTransform;

    void Start()
    {
        ballTransform = GameObject.FindWithTag("Ball").transform;
        opponentRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) lerpSpeed = 0.04f; // Easy
        if (Input.GetKeyDown(KeyCode.Alpha2)) lerpSpeed = 0.08f; // Medium
        if (Input.GetKeyDown(KeyCode.Alpha3)) lerpSpeed = 0.15f; // Hard
    }

    void FixedUpdate()
    {
        if (ballTransform == null) return;

        if (ballTransform.position.x > 0) {
            float targetY = Mathf.Lerp(opponentRB.position.y, ballTransform.position.y, lerpSpeed);
            float clampedY = Mathf.Clamp(targetY, -yBoundary, yBoundary);
            opponentRB.MovePosition(new Vector2(opponentRB.position.x, clampedY));
        }
    }
}