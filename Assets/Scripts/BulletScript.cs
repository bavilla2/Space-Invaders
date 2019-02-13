using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;

//public class IntUnityEvent: UnityEvent<int> { }

public class BulletScript : MonoBehaviour
{
    //public static Bullet instance;

    /*void Awake()
    {
        //instance = this;
    }*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Sides"))  
        {
            Destroy(this);
        }
    }*/

    void OnTriggerEnter2D(Collider2D collider)
    {
        /*if (collider.CompareTag("Enemy"))
        {
            destroyedEnemy.Invoke();
            //score++;
            //onCoinPickup.Invoke();
        }*/

        if(collider.CompareTag("Sides"))
        {
            Debug.Log("I hit the top in bullet script");
            Destroy(this.gameObject);
            Player.instance.shot = false;
        }
    }
}
