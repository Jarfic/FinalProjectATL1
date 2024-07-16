using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEngine.AI.NavMeshAgent enemy;
    public Transform player;
    [SerializeField] private float timer;


    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 5f;
    public float bulletLifeTime = 3f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);
        Shoot();
    }

    void Shoot()
    {
        bulletLifeTime -= Time.deltaTime;
        if (bulletLifeTime > 0) return;
        bulletLifeTime = timer;

        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation) as GameObject;

        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();

        bulletRigidbody.AddForce(bulletRigidbody.transform.forward * bulletSpeed);

        Destroy(bullet, bulletLifeTime);
    }
}
