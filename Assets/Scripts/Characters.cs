using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Characters : MonoBehaviour
{
    public float speed;
    private float horizontal;
    Rigidbody2D rb;
   public TextMeshProUGUI coinText;
    public AudioSource coinSound,dieSound,backgroundSound;
    public int coinNumber = 0;


    public GameObject gameOverPanel;
  


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        backgroundSound.Play();
       
    }

    
    void Update()
    {

        
        horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontal * speed * Time.deltaTime,rb.velocity.y);
        

        Vector2 newScale = transform.localScale;
        if(horizontal<0)
        {
            newScale.x = -0.2431778f;
        }
        
        if(horizontal>0)
        {
            newScale.x = 0.2431778f;
        }

        transform.localScale = newScale;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            coinNumber += 1;
            coinText.text = coinNumber.ToString();
            coinSound.Play();
            
        }
        
        else if(collision.gameObject.tag == "bomb")
        {
            Destroy(collision.gameObject);
            dieSound.Play();
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
            backgroundSound.Pause();
            
        }

        
    }


}
