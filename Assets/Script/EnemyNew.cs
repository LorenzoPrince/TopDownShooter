using UnityEngine;

public class EnemyNew : MonoBehaviour
{
    public float maxHealth = 100;
    private float currentHealth;

    public healthStill HealthStill;

    void Start()
    {
        currentHealth = maxHealth;
        if (HealthStill != null)
        {
            HealthStill.maxHealth = maxHealth;
            HealthStill.currentHealth = currentHealth;
            HealthStill.UpdateStill();
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (HealthStill != null)
        {
            HealthStill.currentHealth = currentHealth;
            HealthStill.UpdateStill();
        }

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);

    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colisión detectada con: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("¡Bala detectada!");
            Bullet bullet = collision.gameObject.GetComponent<Bullet>();
            if (bullet != null)
            {
                TakeDamage(bullet.damage);  // Aquí usamos "bullet.damage"
                Destroy(collision.gameObject);
            }
        }
    }
}