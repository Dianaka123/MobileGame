using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;

    private static int score;
    private int timer = 10;

    public static int PlayerScore {
        get { return score; }

        set
        {
            if (value > 0)
            {
                score = value;
            }
        }
    }


    void Start()
    {
        score = 0;
    }
    void Update()
    {
        timer--;
        if (PlayerBehaviour.lose)
        {
            return;
        }

        if (timer < 0)
        {

            score++;
            scoreText.text ="Score: " + PlayerScore;
            timer = 10;
            
        }
    }
}
