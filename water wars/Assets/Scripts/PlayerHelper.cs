using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHelper : MonoBehaviour
{
    float timeBtwAttack;
    public float startTimeBtwAttack;

    private void Start()
    {
        timeBtwAttack = startTimeBtwAttack;
    }

    private void Update()
    {
        if (timeBtwAttack <= 0)
        {
            timeBtwAttack = startTimeBtwAttack;
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            if (timeBtwAttack <= 0)
            {
                collision.collider.GetComponent<Enemy>().TakeDamage(30);
            }
        }
    }
}
