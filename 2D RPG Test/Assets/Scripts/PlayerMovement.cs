using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    bool isMoving = false;

    public bool isAllowedToMove = true;
    

    public float moveSpeed = 5f;

    public Camera cam;
    
 

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;
    Vector2 mousePos;
    Vector2 lookDir;

    void Start()
    {
        isAllowedToMove = true; 
    }

    // Update is called once per frame
    void Update()
    {
        // Input

        /*  movement.x = Input.GetAxisRaw("Horizontal");
          movement.y = Input.GetAxisRaw("Vertical");

          animator.SetFloat("Horizontal", movement.x);
          animator.SetFloat("Vertical", movement.y);
          animator.SetFloat("Speed", movement.sqrMagnitude);
      */
        //close Input

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        Vector2 lookDir = mousePos = rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;

        Debug.Log(mousePos);

        if (!isMoving && isAllowedToMove)
        {
            movement = new Vector2(movement.x, movement.y);
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");


            


            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);


        }     
    }

    private void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
    

}
