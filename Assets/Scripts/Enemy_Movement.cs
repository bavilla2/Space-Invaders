using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    public float speed = 5f;
    public Transform enemies;
    //public Collider2D enemies_collider;
    public bool movesRight = true;
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
            enemies.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            enemies.transform.Translate(Vector3.left * speed * Time.deltaTime);
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
            enemies.transform.Translate(Vector3.down * speed);
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
