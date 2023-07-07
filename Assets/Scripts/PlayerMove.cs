using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{   
    public float moveSpeed = 7f;
    CharacterController cc;
    float gravity = -20f;
    float yVelocity = 0;
    public float jumpPower = 10f;
    public bool isJumping = false;
    
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;

        if(isJumping && cc.collisionFlags == CollisionFlags.Below)
        {
            isJumping = false;
            yVelocity = 0;
        }

        if(Input.GetButtonDown("Jump") && !isJumping)
        {
            yVelocity = jumpPower;
            isJumping = true;
        }

        dir = Camera.main.transform.TransformDirection(dir);

        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;
        
        if (cc.isGrounded) // 땅에 닿았을 때
        {
            dir.y = 0; // 수직 방향 속도를 0으로 설정하여 멈춥니다.
        }

        cc.Move(dir * moveSpeed * Time.deltaTime);

        //transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
