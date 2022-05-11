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
    public int attackDamage;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetMouseButton(0))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
        
    }
    public void Attack()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetTrigger("AttackUp");
        }
        
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetTrigger("AttackDown");
        }

        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetTrigger("AttackLeft");
        }

        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetTrigger("AttackRight");
        }
        

        

        Collider2D[] hitObjects = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, player);

        foreach (Collider2D objects in hitObjects)
        {
            objects.GetComponent<BreakableObjects>().TakeDamage(attackDamage);
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
