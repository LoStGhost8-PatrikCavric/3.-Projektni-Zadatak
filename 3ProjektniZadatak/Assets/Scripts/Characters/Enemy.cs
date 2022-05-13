using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject bullet;
    //public Color bulletColor;
    //public PlayerHealth playerHealth;

    //public float xSpeed;
    //public float ySpeed;

    public bool canShoot;
    public float fireRate;
    public float health = 30;
    public float currHealth = 30;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        /*if (!canShoot)
        {
            return;
        }
        fireRate = fireRate + (Random.Range(fireRate / -2, fireRate / 2));
        InvokeRepeating("Shoot", fireRate, fireRate);

        anim = GetComponent<Animator>();*/
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Spaceship>().TakeDamage();
            
        }
    }*/

    public void TakeDamage(float value)
    {
        currHealth -= value;
        if (currHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("EndMenu");
        }
    }
    /*public void Shoot()
    {
        GameObject temp = (GameObject)Instantiate(bullet, transform.position, Quaternion.identity);
        temp.GetComponent<Bullet>().ChangeDirection();
        temp.GetComponent<Bullet>().ChangeColor(bulletColor);
    }*/
}
