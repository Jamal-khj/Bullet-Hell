using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject enemBullet;
    public Transform bulletPos;
    public GameObject[] enemyPos;

    float timer;

    // Update is called once per frame
    void Update()
    {
        ///the shooting function is executed after a set time
        timer += Time.deltaTime;

        if (timer > 1.5f)
        {
            timer = 0;
            for (int i = 0; i < 3; i++)
            {
                int random = Random.Range(0, enemyPos.Length);
                Shoot(random);
            }
        }
    }

    public void Shoot(int index)
    {
        Instantiate(enemBullet, enemyPos[index].transform.position, Quaternion.identity);
    }
}
