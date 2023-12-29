using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Camera cam;

    public float speed;
    public float dashSpeed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    private Vector2 mousePosition;

    public Weapon weaponScript;

    private float timeBtwShots;
    public float startTimeBtwShots;

    private float timeBtwDash;
    public float startTimeBtwDash;

    public int maxHealth;
    public int currentHealth;

    public HealthBar healthBar;

    public Transform dashTrail;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        timeBtwShots = startTimeBtwShots;
        timeBtwDash = startTimeBtwDash;
    }

    private void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;

        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);

        if (timeBtwDash <= 0 && Input.GetKeyDown(KeyCode.LeftShift))
        {
            StartCoroutine(Dash());
            timeBtwDash = startTimeBtwDash;
        }
        else
        {
            timeBtwDash -= Time.deltaTime;
        }

        if (timeBtwShots <= 0 && Input.GetMouseButton(0))
        {
            weaponScript.Fire();
            timeBtwShots = startTimeBtwShots;
        }
        else { 
            timeBtwShots -= Time.deltaTime;
        }

        if (currentHealth <= 0)
        {
            Time.timeScale = 0.05f;
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        healthBar.SetHealth(currentHealth);
    }

    IEnumerator Dash()
    {
        speed = dashSpeed;
        dashTrail.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.1f);

        speed = 5;
        dashTrail.gameObject.SetActive(false);
    }
}
