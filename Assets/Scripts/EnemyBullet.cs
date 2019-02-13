using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            Debug.Log("hit player");
            Destroy(collider.gameObject);
            Destroy(this.gameObject);
            //Player.instance.shot = false;
            //Debug.Log("Score: " + score);
        }
    }
}
