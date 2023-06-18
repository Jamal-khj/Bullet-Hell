using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public ParticleSystem Poof;

    void Start ()
    {
        Poof = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Poof.Play();
        }
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Bullet"))
        {
            //Poof.Play();
            Destroy(col.gameObject);
            Destroy(gameObject);
            
        }
    }

    
    
}
