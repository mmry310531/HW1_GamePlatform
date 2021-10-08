using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public Rigidbody2D rg;

    public Animator animator;
    public CharacterController2D controller;
    public float speed;

    private float HorizotalMove;
    private float Jump;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        rg = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizotalMove = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;



    }
    void FixedUpdate()
    {
        controller.Move(HorizotalMove, false, false);

        //if (HorizotalMove > 0)
        //{
        //    transform.forward = new Vector2(1, 0);
        //}
        //else
        //{
        //    transform.forward = new Vector2(-1, 0);
        //}
    }
}
