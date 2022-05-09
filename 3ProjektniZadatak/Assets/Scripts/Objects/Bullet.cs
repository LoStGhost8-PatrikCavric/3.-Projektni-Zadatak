using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    int dir = 1;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void ChangeDirection()
    {
        dir *= -1;
    }

    public void ChangeColor(Color color)
    {
        GetComponent<SpriteRenderer>().color = color;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, 12 * dir);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (dir == 1)
        {
            if (collision.gameObject.tag == "Player")
            {
                collision.gameObject.GetComponent<Spaceship>().TakeDamage();
                Destroy(gameObject);
            }
        }
        else
        {
            if (collision.gameObject.tag =="Enemy")
            {
                collision.gameObject.GetComponent<Enemy>().TakeDamage();
                Destroy(gameObject);
            }
        }
    }
}
