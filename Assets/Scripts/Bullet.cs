using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 10f;
    public float lifetime = 10f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void OnCollisionEnter(Collision collision)
    {
 
        PlayerHealth playerHealth = collision.collider.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
        }

        EnemyHealth enemyHealth = collision.collider.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(damage);
        }

        // Destruye la bala después de colisionar
        Destroy(gameObject);
    }
}
