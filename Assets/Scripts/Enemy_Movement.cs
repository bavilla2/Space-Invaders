using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    public float speed = 5f;
    public Transform enemies;
    public Vector3 moveRight = new Vector3(0.25f, 0, 0);
    public Vector3 moveLeft = new Vector3(-0.25f, 0, 0);
    public Vector3 moveDown = new Vector3(0, -1.5f, 0);
    public static bool movesRight = true;
    // Start is called before the first frame update
    void Start()
    {
        //enemies_collider = this.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (movesRight)
        {
            enemies.transform.Translate(moveRight * speed * Time.deltaTime);
        }
        else
        {
            enemies.transform.Translate(moveLeft * speed * Time.deltaTime);
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Sides"))
        {
            Debug.Log("fuck");
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Sides"))
        {
            Debug.Log("Hello world");
            enemies.transform.Translate(moveDown);
            if(movesRight)
            {
                movesRight = false;
            }
            else {
                movesRight = true;            
            }
        }

        if (collider.CompareTag("Enemy"))    // CompareTag is more efficient than doing collider.tag == "Coin"
        {
            Destroy(collider.gameObject);
            //score++;
            //onCoinPickup.Invoke();
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        //enemies.transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
