using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffects : MonoBehaviour
{
     public ParticleSystem particleSystem;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            Destroy();
        }
    }

    public void Destroy()
    {
        Instantiate(particleSystem, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
