using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator anim;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask breakableObjects;
    public float attackRate;
    public float nextAttackTime = 0f;
    public int attackDamage;
    

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
        anim.SetTrigger("AttackUp");

        anim.SetTrigger("AttackDown");

        anim.SetTrigger("AttackLeft");

        anim.SetTrigger("AttackRight");
        Collider2D[] hitObjects = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, breakableObjects);

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
