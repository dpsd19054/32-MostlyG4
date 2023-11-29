using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public float speed = 7f;

    public Rigidbody2D rb;

    Vector2 movement;
    void Start()
    {

    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        //  transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
        //  transform.Translate(Input.GetAxis("Vertical") * speed * Time.deltaTime, 0, 0);
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

    }
}
