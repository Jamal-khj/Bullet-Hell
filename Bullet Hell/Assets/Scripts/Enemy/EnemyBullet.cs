using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject enemBullet;
    public Transform bulletPos;

    float timer;

    // Update is called once per frame
    void Update()
    {
        ///the shooting function is executed after a set time
        timer += Time.deltaTime;

        if (timer > 3)
        {
            timer = 0;
            Shoot();
        }
    }

    public void Shoot()
    {
        Instantiate(enemBullet, bulletPos.position, Quaternion.identity);
    }
}
