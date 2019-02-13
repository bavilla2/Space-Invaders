using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    public float speed = 5f;
    public Transform enemies;
    public Vector3 moveRight = new Vector3(0.5f, 0, 0);
    public Vector3 moveLeft = new Vector3(-0.5f, 0, 0);
    public Vector3 moveDown = new Vector3(0, -12f, 0);
    public static bool movesRight = true;
    // Start is called before the first frame update
    void Start()
    {
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

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Sides"))
        {
            enemies.transform.Translate(moveDown*Time.deltaTime);
            if(movesRight)
            {
                movesRight = false;
            }
            else {
                movesRight = true;            
            }
        }
    }
}
