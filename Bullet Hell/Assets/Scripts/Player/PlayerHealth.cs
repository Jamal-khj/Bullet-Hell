using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Andrew Roberts' Script
/// </summary>
/// 

public class PlayerHealth : MonoBehaviour
{
    public int health;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.rigidbody.CompareTag("enemBullet"))
        {
            health -= 15;
            Debug.Log("Player was hit");
        }
        if (health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
            SceneManager.LoadScene("Dead scene");
        }
    }
}
