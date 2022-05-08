using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject bullet;
    public Color bulletColor;

    //public float xSpeed;
    //public float ySpeed;

    public bool canShoot;
    public float fireRate;
    public int health;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        if (!canShoot)
        {
            return;
        }
        fireRate = fireRate + (Random.Range(fireRate / -2, fireRate / 2));
        InvokeRepeating("Shoot", fireRate, fireRate);

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Spaceship>().TakeDamage();
            
        }
    }

    public void Death()
    {
        Destroy(gameObject);
    }

    public void TakeDamage()
    {
        health--;
        if (health == 0)
        {
            Death();
        }
    }
    public void Shoot()
    {
        GameObject temp = (GameObject)Instantiate(bullet, transform.position, Quaternion.identity);
        temp.GetComponent<Bullet>().ChangeDirection();
        temp.GetComponent<Bullet>().ChangeColor(bulletColor);
    }
}
