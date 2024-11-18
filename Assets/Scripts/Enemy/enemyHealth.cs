using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public int health = 100;
    gameScore score;

    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<gameScore>();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
        score.Score += 1;
    }
}
