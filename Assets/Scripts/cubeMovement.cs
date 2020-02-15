using UnityEngine;

public class cubeMovement : MonoBehaviour {
    // Start is called before the first frame update

    public Rigidbody rb;
    public float forwardForce = 0f;
    public float horizontalForce = 0f;
    public float jumpForce = 0f;

    void Start() {
        //rb.AddForce(0, 200, 550);
    }

    // Update is called once per frame
    void FixedUpdate() {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        rb.AddForce(horizontalForce, 0, 0);
        rb.AddForce(0, jumpForce, 0);
        jumpForce = 0f;
        horizontalForce = 0f;

        if(Input.GetKey("w")){
        	forwardForce = 100;
        } else if (Input.GetKey("s") && forwardForce > 0) {
        	forwardForce -= 10;
        } else if (Input.GetKey("d")) {
            horizontalForce = 40f;
        } else if (Input.GetKey("a")) {
            horizontalForce = -40f;
        } else if (Input.GetKey("j")) {
            jumpForce = 200f;
        }

        if (rb.position.y < -2f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}