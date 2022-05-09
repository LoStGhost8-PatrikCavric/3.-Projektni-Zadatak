using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask player;
    public float attackRate;
    public float nextAttackTime = 0f;
    //public int attackDamage;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
        
    }
    public void Attack()
    {
        
        Collider2D[] hitObjects = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, player);

        foreach (Collider2D objects in hitObjects)
        {
            objects.GetComponent<BreakableObjects>().TakeDamage(10);
        }
    }

    public void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
