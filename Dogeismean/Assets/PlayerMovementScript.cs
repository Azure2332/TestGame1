using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D RB;

    public float timer;

    Vector2 Movement;

    // Update is called once per frame
    void Update()
    {
        //input

        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("YOU PRESSED E GREAT JOB");

        }
    }
    private void FixedUpdate()
    {
        //movement

        RB.MovePosition(RB.position + Movement * moveSpeed * Time.fixedDeltaTime);

    }
}
