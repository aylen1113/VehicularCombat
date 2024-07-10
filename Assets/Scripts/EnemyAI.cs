using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    public float stopDistance = 10f;
    private NavMeshAgent agent;

    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;
    public float fireRate = 1f;

    private float nextFireTime;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) > stopDistance)
        {
            agent.SetDestination(target.position);
        }
        else
        {
            agent.ResetPath();
        }

        if (Time.time > nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = firePoint.forward * bulletSpeed;
    }
}

