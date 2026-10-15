using UnityEngine;

public class CustomGravity : MonoBehaviour
{
    [SerializeField] private float gravityScale = 1.0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        
        Debug.Log(Physics.gravity);
    }

    void FixedUpdate()
    {
        rb.AddForce(Physics.gravity * gravityScale, ForceMode.Acceleration);
    }
}