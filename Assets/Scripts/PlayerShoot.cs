using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject Bullet;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Vector3 pos = transform.position;
            Instantiate(Bullet, pos, Quaternion.identity);
        }
    }
}
