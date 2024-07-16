using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class EnemyBullet : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource sound;
    public AudioClip playerDieSound;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(25);
            if(other.gameObject.GetComponent<PlayerHealth>().currentHealth == 0)
            {
                foreach(EnemyFollower enemy in FindObjectsOfType<EnemyFollower>())
                {
                    enemy.gameObject.SetActive(false);
                }
                GameManager.instance.Invoke("GameOver", 0);
                other.gameObject.GetComponent<FirstPersonController>().enabled = false;
            }
        }
    }
}
