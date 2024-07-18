using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon1: MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cameraTransform;
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 200f;
    public float bulletLifeTime = 3f;
    public float cooldown;
    float lastShot;
    public AudioSource soundShoot;
    public AudioClip shootSound;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if(Time.time-lastShot<cooldown)
        {
            return;
        }
        lastShot = Time.time;

        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);

        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();

        bulletRigidbody.velocity = cameraTransform.forward * bulletSpeed;

        soundShoot.PlayOneShot(shootSound);

        Destroy(bullet, bulletLifeTime);

        
    }
}
