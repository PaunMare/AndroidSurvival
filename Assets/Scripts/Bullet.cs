using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
   // public Animation anima;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            
            Debug.Log(collision.name);
            Destroy(this.gameObject);
            PlayerMovement.score++;
            Debug.Log(PlayerMovement.score.ToString());
        }
        
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
