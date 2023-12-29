using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject projectile;

    public float fireForce;

    public void Fire()
    { 
        GameObject projectileGO = Instantiate(projectile, transform.position, transform.rotation);
        projectileGO.GetComponent<Rigidbody2D>().AddForce(transform.up * fireForce, ForceMode2D.Impulse);
    }
}
