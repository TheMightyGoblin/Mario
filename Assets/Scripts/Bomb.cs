using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField]float bombHorizontalSpeed = 10f;
    [SerializeField]float bombVerticalSpeed = 5f;
    Rigidbody2D myRigidBody;
    PlayerMovement player;
    float xSpeed;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerMovement>();
        xSpeed = player.transform.localScale.x*bombHorizontalSpeed;
        myRigidBody.velocity += new Vector2(xSpeed, bombVerticalSpeed);
    }
    
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}
