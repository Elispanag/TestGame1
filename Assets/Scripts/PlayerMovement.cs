using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    void FixedUpdate()
    {   
        // Add a forward force
         rb.AddForce(0, 0, forwardForce * Time.fixedDeltaTime); 
         
        // Movement to the right
        if ( Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }
        // Movement to the left
        if ( Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
