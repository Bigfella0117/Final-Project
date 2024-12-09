using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject thisobject;
    public int health;
    public GameObject EnemyManager;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            health -= 1;
            if (health <= 0)
            {
                EnemyManager.GetComponent<EnemyManager>().enemyCount--;
                Debug.Log(EnemyManager.GetComponent<EnemyManager>().enemyCount);
                Destroy(thisobject);
            }
        }
    }

   
}
