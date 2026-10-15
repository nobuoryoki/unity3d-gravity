using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log(Physics2D.gravity);
        Debug.Log(rb.gravityScale);
    }
}
