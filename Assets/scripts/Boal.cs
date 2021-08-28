using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boal : MonoBehaviour
{

    [SerializeField] Rigidbody2D rigibody;
    Vector2 moveDirection;
    Vector2 currentVelocity;

    void Start()
    {
        // rigidbody2D = GetComponent<Rigidbody2D>();
        rigibody.velocity = Vector2.up;
    }

    private void FixedUpdate()
    {
        currentVelocity = rigibody.velocity;
    }

    private void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveDirection = Vector2.Reflect(currentVelocity,collision.GetContact(0).normal);
        rigibody.velocity = moveDirection;
    }
}
