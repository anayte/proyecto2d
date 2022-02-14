using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    [SerializeField] private float walkSpeed = 7f;
    [SerializeField] private float jumpHeight = 8f;
    [SerializeField] private LayerMask jumpableLayers;
    [SerializeField] private float jumpStartingVel = 4f;
    private Rigidbody2D rb;
    private CapsuleCollider2D capCollider;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        capCollider = GetComponent<CapsuleCollider2D>();
    }
    
    void Start()
    {     

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void move(float moveX){
        rb.velocity = new Vector2 ( moveX * walkSpeed, rb.velocity.y );
    }
        
    public void jump(bool value)
    {
        if (!capCollider.IsTouchingLayers(jumpableLayers)){return;}

        if (value){
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }
    }
}