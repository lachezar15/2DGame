using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;

    float timeBtwAttack;
    public float startTimeBtwAttack;

    private void Start()
    {
        timeBtwAttack = startTimeBtwAttack;
        StartCoroutine(Dash());
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

    IEnumerator Dash()
    {
        float time = Random.Range(1, 5);

        yield return new WaitForSeconds(time);

        float offset = Random.Range(-1, 2);
        float offset2 = Random.Range(-1, 2);
        transform.position = new Vector3(transform.position.x + offset, transform.position.y + offset2, transform.position.z);

        StartCoroutine(Dash());
    }
}
