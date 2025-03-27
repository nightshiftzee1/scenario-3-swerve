using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Swerveplayer2d : MonoBehaviour
{
    public bool AllowJumping = true; // Still retains jumping functionality
    public float JumpPower = 1;      // Jump power
    public float groundedOffset = -0.14f; // Offset to check ground collision
    public LayerMask GroundLayerMask;     // Ground collision layer mask

    private Rigidbody2D rb;
    private bool isGrounded;
    private Vector2 spherePos = Vector2.zero;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(spherePos, 0.5f); 
    }

    private void Update()
    {
        DragObject();
    }

    private void DragObject()
    {
        if (Input.GetMouseButton(0)) // Check if the left mouse button is held down which is bad as I shouldnt be using mouse but will change later
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
            transform.position = new Vector2(mousePosition.x, transform.position.y);         }
    
    }
}
//removed ground check and jumping capabilities
