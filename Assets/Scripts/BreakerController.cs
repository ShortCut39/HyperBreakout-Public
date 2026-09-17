using System;
using UnityEngine;
using UnityEngine.UIElements;


public class BreakerController : MonoBehaviour
{
    public int breakerHP = 0;
    public GameObject ExplosionObstacle;
    Color pinkColor = Color.hotPink;
    Color blueColor = Color.blue;
    Color redColor = Color.red;
    Color greenColor = Color.green;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

        if (breakerHP == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().color = pinkColor;
        }

        if (breakerHP == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().color = blueColor; 
        }

        if (breakerHP == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().color = greenColor;
        }

        if (breakerHP == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().color = redColor;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball") && breakerHP == 0)
        {
            Destroy(gameObject);
            GameObject explosion = Instantiate(ExplosionObstacle, transform.position, transform.rotation);
            
            Destroy(explosion,5);
            
            
            


        }
        else
        {
            breakerHP--;
            if (breakerHP == 2)
            {
                gameObject.GetComponent<SpriteRenderer>().color = blueColor; 
            }

            if (breakerHP == 1)
            {
                gameObject.GetComponent<SpriteRenderer>().color = greenColor;
            }

            if (breakerHP == 0)
            {
                gameObject.GetComponent<SpriteRenderer>().color = redColor;
            }
        }
    }
}
