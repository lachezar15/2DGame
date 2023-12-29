using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public Rigidbody2D rb;

    public GameObject BreakPS;

    private void Start()
    {
        Destroy(gameObject, 2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player")
        {
            if (collision.tag == "Enemy")
            {
                collision.GetComponent<Enemy>().TakeDamage(20);
                Instantiate(BreakPS, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }

            Instantiate(BreakPS, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
