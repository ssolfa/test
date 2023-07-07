using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject HitSpark;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Bullet")
        {
            return;
        }

        if (collision.transform.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemy>().TakeDamage(5);
        }

        Instantiate(HitSpark, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
