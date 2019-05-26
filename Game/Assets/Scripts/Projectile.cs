using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float distance;
    public int damageToGive=5;
    public LayerMask whatIsSolid;

    public GameObject destroyEffect;

    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }

    private void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void DestroyProjectile()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Enemy")
        {
            Destroy(other.gameObject);
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);
            //other.gameObject.GetComponent<EnemyHealthManager>().
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Wall")
        {
                Destroy(gameObject);

        }
        if (other.gameObject.tag == "Tom")
        {
            Destroy(gameObject);

        }
    }
    /*public void DestroyBullet(GameObject other)
    {
        Destroy(other);
    }*/

}
