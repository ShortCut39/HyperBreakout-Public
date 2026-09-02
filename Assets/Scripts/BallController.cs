using UnityEngine;

public class BallController : MonoBehaviour
{
    Collider2D cd;
    Rigidbody2D rb;
    public GameObject Breaker;
    public GameObject Player;
    public float speed = -3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cd = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(0,speed);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
            
            
        
        
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Breaker"))
        {
            Destroy(collision.gameObject);
        }
    }
}
