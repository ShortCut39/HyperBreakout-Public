using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float x = 0;
    public float y = -4;
    public float z = 0;
    
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     rb = GetComponent<Rigidbody2D>();   
        
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
        Debug.Log("A");
            rb.linearVelocity = Vector2.left;
            
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.linearVelocity = Vector2.right;
            
        }
        
        
    }
}
