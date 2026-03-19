using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float speed = 5f;
    public Transform[] destinations;

    Animator animator;

    SpriteRenderer sprite;

    int currentIndex = 0; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if(destinations.Length == 0)
        {
            animator.SetBool("b_isWalking", false);
            return;
        }

        animator.SetBool("b_isWalking", true);


        var currentDestination = destinations[currentIndex];

        sprite.flipX = transform.position.x > currentDestination.position.x;

        transform.position = Vector3.MoveTowards(transform.position,
            currentDestination.position,
            speed * Time.deltaTime);
        if(Vector3.Distance(transform.position, currentDestination.position) <= 0.1f)
        {
            currentIndex = (currentIndex + 1) % destinations.Length;
        }
    }
}
