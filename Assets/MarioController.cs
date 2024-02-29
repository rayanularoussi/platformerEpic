using UnityEngine;

public class MarioController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sprintSpeedMultiplier = 2f;
    public float jumpForce = 8f;
    public LayerMask groundMask;
    public Transform groundCheck;

    private Rigidbody rb;
    private Animator animator;
    private bool isGrounded;
    private bool isJumping;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.1f, groundMask);
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        float currentMoveSpeed = moveSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentMoveSpeed *= sprintSpeedMultiplier;
            animator.SetFloat("Speed", 1f);
        }
        else
        {
            animator.SetFloat("Speed", 0.5f);
        }

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical) * currentMoveSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + movement);

        if (moveHorizontal != 0)
        {
            transform.rotation = Quaternion.LookRotation(new Vector3(moveHorizontal, 0f, 0f));
        }

        
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
                isJumping = true;
                animator.SetBool("IsJumping", true);
            }
            else
            {
                isJumping = false;
            }
        
        
        animator.SetBool("IsJumping", isJumping);
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
