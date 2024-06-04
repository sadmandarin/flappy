using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    private float force = 2f;

    private bool canFly = false;

    private void Awake()
    {
        Time.timeScale = 1.0f;
    }
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();    
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canFly = true;
        }
    }

    private void FixedUpdate()
    {
        if (canFly)
        {
            Flap();
        }
    }

    void Flap()
    {
        rigidBody.velocity = Vector3.zero;

        rigidBody.AddForce(new Vector2(0, force), ForceMode2D.Impulse);

        canFly = false;
    }
}
