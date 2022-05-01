using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spaceship : MonoBehaviour
{
    public float speed;
    public int health;
    int shootDelay;
    GameObject gunA, gunB;
    public GameObject bullet;
    

    private void Awake()
    {
        gunA = transform.Find("gunA").gameObject;
        gunB = transform.Find("gunB").gameObject;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }

        else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }

        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.Space) && shootDelay > 10)
        {
            Shoot();
            shootDelay++;
        }
        
    }

    public void TakeDamage()
    {
        health--;
        if (health == 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }

    public void Shoot()
    {
        Instantiate(bullet, gunA.transform.position, Quaternion.identity);
        Instantiate(bullet, gunB.transform.position, Quaternion.identity);
    }
}
