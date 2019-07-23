
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public static bool lose;

    [SerializeField]
    private GameObject restart;
    [SerializeField]
    private GameObject exit;


    private void Awake()
    {
        lose = false;
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bomb"))
        {
            lose = true;
            restart.SetActive(true);
            exit.SetActive(true);
        }
    }
}
