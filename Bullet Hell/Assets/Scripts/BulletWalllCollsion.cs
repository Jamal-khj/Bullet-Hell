using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletWalllCollsion : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Wall"))
        {
            
            Destroy(gameObject);
            
        }

        

    }
}
