using UnityEngine;

public class OpponentController : MonoBehaviour
{
    private Transform ballTransform;

    void Start()
    {
        ballTransform = GameObject.FindWithTag("Ball").transform;
    }

    void Update()
    {
        
    }
}
