using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class BallController : MonoBehaviour
{
    
    Rigidbody2D rb;
    private Button restartbutton;
    public float speed = -3f;
    public UIDocument uiDocument;
    private Label health;
    public int hp = 3;
    private int score = 0;
    public Label scorelabel;
    private Label winlabel;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        scorelabel = uiDocument.rootVisualElement.Q<Label>("scorelabel");
        health = uiDocument.rootVisualElement.Q<Label>("healthlabel");
        restartbutton = uiDocument.rootVisualElement.Q<Button>("restartbutton");
        winlabel = uiDocument.rootVisualElement.Q<Label>("winlabel");
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
        

        if (score >= 90000)
        {
            Destroy(gameObject);
            
            restartbutton.style.display = DisplayStyle.Flex;
            winlabel.style.display = DisplayStyle.Flex;
            winlabel.text = "Gewonnen!!!";
            
        }





    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Breaker"))
        {
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
