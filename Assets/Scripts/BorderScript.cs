﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player Bullet"))
        {
            Debug.Log("hit top");
            Destroy(collision.collider.gameObject);
            Player.instance.shot = false;
            //score++;
            //onCoinPickup.Invoke();
        }
    }
}
