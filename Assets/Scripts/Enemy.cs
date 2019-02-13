using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IntUnityEvent : UnityEvent<int> { }

public class Enemy : MonoBehaviour
{
    private Collider2D m_collider;
    private bool front = false;
    private float raySize = 2.7f;
    private float bulletSpeed = 60.0f;
    [SerializeField] protected GameObject Bullet;

    public static Enemy instance;

    public UnityEvent destroyedEnemy;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        m_collider = this.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        checkFront();
        if (front && (Random.value <= .001f))
        {
            shoot();
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player Bullet"))
        {
            Debug.Log("Enemy in enemy script");
            Destroy(collider.gameObject);
            Destroy(this.gameObject);
            Player.instance.shot = false;
            destroyedEnemy.Invoke();
            //Debug.Log("Score: " + score);
        }
    }



    void checkFront()
    {
        Vector2 feetPosition = new Vector2(this.transform.position.x, m_collider.bounds.min.y-.1f);
        RaycastHit2D hitInfo = Physics2D.Raycast(feetPosition, Vector2.down, raySize);
        Debug.DrawRay(feetPosition, Vector2.down * raySize, Color.green);
        if (!hitInfo)//&& !hitInfo.collider.CompareTag("Enemy"))// && !hitInfo.collider.CompareTag("GameController"))
        {
            //Debug.Log(true);
            this.front = true;
        }
        //Debug.Log(hitInfo.collider.tag);
    }

    void shoot()
    {
        GameObject bullet = Instantiate(Bullet, this.transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().velocity = Vector2.down * bulletSpeed;
        Physics2D.IgnoreCollision(m_collider, bullet.GetComponent<Collider2D>());
    }
}
