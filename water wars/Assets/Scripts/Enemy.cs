using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;

    float timeBtwAttack;
    public float startTimeBtwAttack;

    public GameObject diamondPickup;

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

        if (health <= 0)
        {
            int rand = Random.Range(0, 5);
            if (rand == 3)
            {
                Instantiate(diamondPickup, transform.position, Quaternion.identity);
            }
            Destroy(this.gameObject);
        }
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            if (timeBtwAttack <= 0)
            {
                collision.collider.GetComponent<Player>().TakeDamage(10);
            }
        }
    }
}
