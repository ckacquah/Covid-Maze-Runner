using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed = 5f;
    public Animator animator;

    Vector2 movement;
    Vector2 previous;

    // Update is called once per frame
    void Update()
    {
        if (!FindObjectOfType<LevelManager>().IsGameOver())
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement.x = 0;
            movement.y = 0;
        }

        if (movement.sqrMagnitude > 0)
        {
            previous = movement;
            animator.SetBool("Moving", true);
        }
        else
        {
            animator.SetBool("Moving", false);
        }

        animator.SetFloat("Speed", movement.sqrMagnitude);
        
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Horizontal", movement.x);
        
        animator.SetFloat("Previous_Vertical", previous.y);
        animator.SetFloat("Previous_Horizontal", previous.x);
    }

    void FixedUpdate()
    {
        // Movement
        GetComponent<Rigidbody2D>().MovePosition(GetComponent<Rigidbody2D>().position + movement * movementSpeed * Time.fixedDeltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            FindObjectOfType<ThemeMusic>().Pause();
            FindObjectOfType<LevelManager>().EndGame();
        }
        else if (collision.gameObject.tag == "Stop_tile")
        {
            FindObjectOfType<ThemeMusic>().Pause();
            FindObjectOfType<LevelManager>().FinishGame();
        }
    }
}
