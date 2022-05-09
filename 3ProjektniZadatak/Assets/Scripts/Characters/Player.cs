using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public int health;
    public float speed = 0f;
    public Animator anim;
    //public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
            anim.SetInteger("AnimState", 1);
            

        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
            anim.SetInteger("AnimState", 2);
            
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

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Trap")
        {
            health--;
        }
    }


}
