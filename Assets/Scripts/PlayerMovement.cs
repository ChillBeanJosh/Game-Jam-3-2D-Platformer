using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    public float speed;
    public float jumpingPower;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal"); //For Left and Right to Work. 

        if (Input.GetButtonDown("Jump") && IsGrounded()) //"Jump" is the SpaceBar, can be changed in settings.
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }
                                                                
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f) //These Two Jumps are to have controlled Jump Heights Based on How long You Hold it Down For.
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }



        if(horizontal < 0 && isFacingRight)  //uses to flip the player left and right
        {
            Flip();
        }
        else if (horizontal > 0 && !isFacingRight)
        {
            Flip();
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y); //Gives The Player Force To Move.


    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer); //Condition that only allows Jump While On a "Ground" Layer.
    }

    private void Flip() //flips the player left and right, but iffy with projectiles (Needs Fixing).
    {
      
        isFacingRight = !isFacingRight; 
        transform.Rotate(0f, 180f, 0f);   
    }   
            
        

       
    
}