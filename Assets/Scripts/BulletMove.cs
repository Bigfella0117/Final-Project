using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float speed = 2f;
    public GameObject thisobject;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(thisobject);
        }
    }
    void FixedUpdate()
    {
        Vector3 pos = transform.position;
        pos.y += speed * Time.deltaTime;
        transform.position = pos;
    }
}

