using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newbullet : MonoBehaviour
{
    public GameObject HitSpark;

    void Start()
    {

    }

    void Update()
    {

    }

    public void HitEnemy()
    {
        Instantiate(HitSpark, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<newenemy>().TakeDamage(5);
        }

        Instantiate(HitSpark, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
