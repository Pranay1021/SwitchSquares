using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gre : MonoBehaviour
{
    
        public Rigidbody2D rb;
        public float speed;
        public Transform groundcheckpoint;
          public float groundcheckradius;
         public LayerMask groundlayer;
        private bool isonground;
    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        isonground = Physics2D.OverlapCircle(groundcheckpoint.position, groundcheckradius, groundlayer);
        if (Input.GetKeyDown(KeyCode.I)&& isonground)
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
    }
    public void grebutton()
    {
        if (isonground)
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
    }
}

