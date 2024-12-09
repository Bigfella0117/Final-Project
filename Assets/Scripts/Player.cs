using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject HealthManager;
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("EnemyBullet"))
        {
            HealthManager.gameObject.GetComponent<HealthManager>().TakeDamage(coll.gameObject.GetComponent<Bullet>().damage);
        }
    }
}
