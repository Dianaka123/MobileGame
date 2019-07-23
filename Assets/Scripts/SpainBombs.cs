using System.Collections;
using UnityEngine;

public class SpainBombs : MonoBehaviour
{
    [SerializeField]
    private GameObject bomb;

    [SerializeField]
    private float hight;

    private const float board = 2.5f;
    private IEnumerator coroutine;

    private void Start()
    {
        hight = 5.9f;
        StartCoroutine(Spawn());
    }

    

    private IEnumerator Spawn()
    {
        while (!PlayerBehaviour.lose)
        {
            Instantiate(bomb, new Vector2(Random.Range(-1 * board, board), hight), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
        }
    }
}
