using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    
    private Vector2 moveInput;
    public float jumpForce = 1f;
    public float moveSpeed = 1f;
    private Rigidbody2D rb;
    private Animator myAnimator;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myAnimator.SetBool("move", false);
    }

    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "pit")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            SceneManager.LoadScene("PlayScene_" + collision.name);
        }
        if (collision.name == "Boss")
        {
            Destroy(collision.gameObject);
        }
    }

  



 




    public void OnMove(InputValue value)
    {
       moveInput = value.Get<Vector2>();
    }


    public void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(moveInput.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (moveInput.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        


        if (moveInput.magnitude > 0)
        {
            myAnimator.SetBool("move", true);    
        }
        else
        {
            myAnimator.SetBool("move", false);
        }

        transform.Translate(Vector3.right * moveSpeed * moveInput.x * Time.deltaTime);
    }
}
