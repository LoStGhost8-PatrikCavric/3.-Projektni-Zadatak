using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float shootSpeed, shootTimer;

    private bool isShooting;

    public Transform shootPos, shootPos2;
    public GameObject projectile;

    void Start()
    {
        isShooting = false;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !isShooting)
        {
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {
        isShooting = true;
        GameObject newProjectile = Instantiate(projectile, shootPos.position, Quaternion.identity);
        newProjectile.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, shootSpeed * Time.fixedDeltaTime);

        GameObject newProjectile2 = Instantiate(projectile, shootPos2.position, Quaternion.identity);
        newProjectile2.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, shootSpeed * Time.fixedDeltaTime);
        yield return new WaitForSeconds(shootTimer);
        isShooting = false;
    }
}
