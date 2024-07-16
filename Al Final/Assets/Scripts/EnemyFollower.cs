using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.FirstPerson;

public class EnemyFollower : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent agent;
    public Transform target;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(25);
            if(other.gameObject.GetComponent<PlayerHealth>().currentHealth == 0)
            {
                GameManager.instance.Invoke("GameOver", 0);
                other.gameObject.GetComponent<FirstPersonController>().enabled = false;
            }
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            agent.SetDestination(target.position);
        }
    }
}