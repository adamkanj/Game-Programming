using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Controller : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private float moveInput;
    private float speed=10f;
    public TMP_Text scoreText;
    private float topscore = 0.0f;

    
    // Start is called before the first frame update
    void Start()
    {
        
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        if (moveInput > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }

       if (rb2d.velocity.y > 0 & transform.position.y > topscore)
        {
            topscore = transform.position.y;
        }
        
        scoreText.text = "Score " + Mathf.Round(topscore).ToString();
        
    }
    void FixedUpdate()
    {

        moveInput = Input.GetAxis("Horizontal");

        rb2d.velocity = new Vector2 (moveInput* speed, rb2d.velocity.y);

    }
}
