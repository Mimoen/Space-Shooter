using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    public float speed = 10f;
    public int damage = 40;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 10)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Ship enemy = hitInfo.GetComponent<Ship>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
