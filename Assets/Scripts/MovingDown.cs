using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDown : MonoBehaviour
{
 
    private static float fallSpeed;

    private const float destroyBoard = -5f;

    private void Start()
    {
        fallSpeed = 5;
    }

    private void Update()
    {
        UpdateSpeed(100, 200, 6);
        UpdateSpeed(200, 300, 7);
        UpdateSpeed(300, Mathf.Infinity, 8);


        if (transform.position.y < destroyBoard)
        {
            Destroy(gameObject);
        }

        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
       
        print("Speed: " + fallSpeed);
    }

    void UpdateSpeed(int minScore, float maxScore, float speed)
    {
        if (Score.PlayerScore > minScore && Score.PlayerScore < maxScore)
        {
            fallSpeed = speed;
        }
    }
}
