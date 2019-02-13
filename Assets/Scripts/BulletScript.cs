using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
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
        if(collider.CompareTag("Sides"))
        {
            Debug.Log("I hit the top in bullet script");
            Destroy(this.gameObject);
            Player.instance.shot = false;
        }

        if (collider.CompareTag("Tier1 Enemy"))
        {
            Debug.Log("Enemy in enemy script");
            Destroy(collider.gameObject);
            Destroy(this.gameObject);
            Player.instance.shot = false;
            Player.instance.destroyedEnemy.Invoke(10);
        }

        if (collider.CompareTag("Tier2 Enemy"))
        {
            Debug.Log("Enemy in enemy script");
            Destroy(collider.gameObject);
            Destroy(this.gameObject);
            Player.instance.shot = false;
            Player.instance.destroyedEnemy.Invoke(20);
        }

        if (collider.CompareTag("Tier3 Enemy"))
        {
            Debug.Log("Enemy in enemy script");
            Destroy(collider.gameObject);
            Destroy(this.gameObject);
            Player.instance.shot = false;
            Player.instance.destroyedEnemy.Invoke(40);
        }


    }
}
