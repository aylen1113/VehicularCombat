using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
   
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletSpeed = 20f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = bulletSpawn.forward * bulletSpeed;

        Destroy(bullet, 2.0f);
    }
}
