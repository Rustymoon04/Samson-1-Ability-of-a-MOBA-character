using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroscript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform gunEnd; 
    public float fireCooldown = 1f;
    private float nextFireTime = 0f;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("Fire1") && Time.time >= nextFireTime) 
       {
        FireBullet();
        nextFireTime = Time.time + fireCooldown;
       }
    }

    void FireBullet()
    {
        Instantiate(bulletPrefab, gunEnd.position, gunEnd.rotation);
    }
}
