using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public AudioSource enemySound;
    public AudioClip enemyDieSound;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
            collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(damage);
            if(collision.gameObject.GetComponent<EnemyHealth>().currentHealth == 0)
            {
                enemySound.PlayOneShot(enemyDieSound);
                GameManager.instance.UpdateScore(1);
                Destroy(collision.gameObject);
            }
        }
    }
}
