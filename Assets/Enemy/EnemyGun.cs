using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public Rigidbody Bullet;
    public AudioClip GunShot;
    public float BulletSpeed;
    public GameObject GunSpark;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Attack(){
            Rigidbody rb=(Rigidbody)Instantiate(Bullet,transform.position,transform.rotation);
            rb.velocity=transform.TransformDirection(new Vector3(0,0,BulletSpeed));
            AudioSource.PlayClipAtPoint(GunShot,transform.position);
            Instantiate(GunSpark,transform.position,transform.rotation);
    
    }
}
