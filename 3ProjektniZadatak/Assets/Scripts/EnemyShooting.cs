using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    //public bool canShoot;
    public bool isShooting;
    public GameObject enemyProjectile;
    public Transform shootingPos;
    public float shootSpeed, shootTimer;
    void Start()
    {
        //canShoot = true;
        isShooting = false;
    }
    void Update()
    {
        if (isShooting == false)
        {
            StartCoroutine(EnemyShot());
        }
        
    }

    IEnumerator EnemyShot()
    {
        isShooting = true;
        yield return new WaitForSeconds(shootTimer);
        GameObject newProjectile = Instantiate(enemyProjectile, shootingPos.position, Quaternion.identity);
        newProjectile.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, shootSpeed * Time.fixedDeltaTime);
        isShooting = false;
    }
}
