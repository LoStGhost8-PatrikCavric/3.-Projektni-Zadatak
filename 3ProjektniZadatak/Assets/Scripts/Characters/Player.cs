using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    int shootDelay = 0;
    GameObject gunA, gunB;
    public GameObject bullet;
    public float speed = 0f;
    public Animator anim;
    public string tekst;
    //public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        gunA = transform.Find("gunA").gameObject;
        gunB = transform.Find("gunB").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
            anim.SetInteger("AnimState", 1);
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }

        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
            anim.SetInteger("AnimState", 2);
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }
        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            anim.SetInteger("AnimState", 3);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            anim.SetInteger("AnimState", 4);
        }


        if (Input.GetKey(KeyCode.Space) && shootDelay > 10)
        {
            Shoot();
            shootDelay++;
        }
        

        else
        {
            anim.SetInteger("AnimState", 0);
        }

        /*if (Input.GetKeyUp(KeyCode.W))
        {
            if (!sound.isPlaying)
            {
                sound.Play();
            }
            else
            {
                sound.Stop();
            }
        }

        else if (Input.GetKeyUp(KeyCode.S))
        {
            if (!sound.isPlaying)
            {
                sound.Play();
            }
            else
            {
                sound.Stop();
            }
        }

        else if (Input.GetKeyUp(KeyCode.A))
        {
            if (!sound.isPlaying)
            {
                sound.Play();
            }
            else
            {
                sound.Stop();
            }
        }

        else if (Input.GetKeyUp(KeyCode.D))
        {
            if (!sound.isPlaying)
            {
                sound.Play();
            }
            else
            {
                sound.Stop();
            }
        }*/
    }
    public void AddCoins(int value)
    {
        GameManager.instance.coins = GameManager.instance.coins + value;
        GameManager.instance.GameUI.transform.Find(tekst).GetComponent<Text>().text = "COINS: " + GameManager.instance.coins;
    }

    public void Shoot()
    {
        Instantiate(bullet, gunA.transform.position, Quaternion.identity);
        Instantiate(bullet, gunB.transform.position, Quaternion.identity);
    }
}
