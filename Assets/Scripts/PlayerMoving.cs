using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    [SerializeField]
    private Transform playerTransform;
    [SerializeField]
    private float speed = 10f;
    [SerializeField]
    private GameObject player;

    private const  float board = 2.5f;
    private Animator animator;

    private void Start()
    {
        animator = player.GetComponent<Animator>();
    }
    private void Update()
    {
        print("Hi!");
        animator.SetBool("lose", PlayerBehaviour.lose);
    }


    private void OnMouseDrag()
    {
        if (!PlayerBehaviour.lose)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x > board ? board : mousePos.x;
            mousePos.x = mousePos.x < (-1 * board )? -1 * board : mousePos.x;

            Vector2 moveVector = new Vector2(mousePos.x, playerTransform.position.y);

            float difference = Mathf.Abs(moveVector.x - playerTransform.position.x);
            print(difference);

            animator.SetFloat("move",difference);

            playerTransform.position = Vector2.MoveTowards(playerTransform.position,
                moveVector,
                speed * Time.deltaTime);
           

        }
    }
}
