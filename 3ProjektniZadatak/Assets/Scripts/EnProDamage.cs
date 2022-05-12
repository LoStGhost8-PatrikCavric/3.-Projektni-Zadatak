using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnProDamage : MonoBehaviour
{
    public float EnDamage = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "spaceship")
        {
            collision.gameObject.GetComponent<Spaceship>().TakeDamage(EnDamage);
            Destroy(gameObject);
        }
    }
}
