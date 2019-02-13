﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] protected float speed = 20;
    [SerializeField] protected float bulletSpeed = 30.0f;
    public GameObject Bullet;
    private Collider2D m_collider;
    public bool shot = false;
    public static Player instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        m_collider = this.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.Mouse0) && !shot)
        {
            Debug.Log("Shoot");
            Shoot();
        }

    }

    void Move()
    {
        float movementModifier = Input.GetAxisRaw("Horizontal");
        this.transform.Translate(new Vector2(movementModifier * speed * Time.deltaTime, 0));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Sides"))
        {
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(Bullet, this.transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().velocity = Vector2.up * bulletSpeed;
        Physics2D.IgnoreCollision(m_collider, bullet.GetComponent<Collider2D>());
        shot = true;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Enemy Bullet"))
        {
            Debug.Log("hit player");
            Destroy(collider.gameObject);
            Destroy(this.gameObject);
            //Player.instance.shot = false;
            //Debug.Log("Score: " + score);
        }
    }
}
