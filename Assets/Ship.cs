using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField] float speed = 2;
    [SerializeField] KeyCode up = KeyCode.W;
    [SerializeField] KeyCode down = KeyCode.S;
    [SerializeField] KeyCode right = KeyCode.D;
    [SerializeField] KeyCode left = KeyCode.A;
    [SerializeField] KeyCode turnRight = KeyCode.E;
    [SerializeField] KeyCode turnLeft = KeyCode.Q;
    // Start is called before the first frame update

    public int health = 100;
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
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up))
        {
            transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(down))
        {
            transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(right))
        {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(left))
        {
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(turnRight))
        {
            transform.Rotate(Vector3.back * speed * 20 * Time.deltaTime);
        }
        if (Input.GetKey(turnLeft))
        {
            transform.Rotate(Vector3.forward * speed * 20 * Time.deltaTime);
        }    
    }
}
