using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class BallController : MonoBehaviour
{
    Collider2D cd;
    Rigidbody2D rb;
    public GameObject Breaker;
    public GameObject Player;
    public GameObject Border_Bottom;
    private Button restartbutton;
    public float speed = -3f;
    public UIDocument uiDocument;
    private Label health;
    public Label scorelabel;
    public int hp = 3;
    private int score = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        health = uiDocument.rootVisualElement.Q<Label>("healthlabel");
        restartbutton = uiDocument.rootVisualElement.Q<Button>("restartbutton");
        scorelabel = uiDocument.rootVisualElement.Q<Label>("scorelabel");
        cd = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(0,speed);
        restartbutton.style.display = DisplayStyle.None;
        restartbutton.clicked += ReloadScene;



    }

    // Update is called once per frame
    void Update()
    {
        health.text = "Leben: " + hp;
        scorelabel.text = "Score: " + score;





    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Breaker"))
        {
            Destroy(collision.gameObject);
            score += 100;
        }

        if (collision.gameObject.CompareTag("Border_Bottom"))
        {
            hp -= 1;

            if (hp <= 0)
            {
                Destroy(gameObject);
                health.text = "Leben: " + hp;

                restartbutton.style.display = DisplayStyle.Flex;
            }


        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        
    }
}
