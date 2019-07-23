using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    [SerializeField]
    Text levelTxt;
    [SerializeField]
    GameObject level;

    void Update()
    {
        if (((int)Score.PlayerScore % 100 == 0 && Score.PlayerScore != 0) || Score.PlayerScore == 1)
        {
            level.SetActive(true);

            levelTxt.text = "Level: " + ((int)(Score.PlayerScore / 100) + 1);
            Corotiens();
            return;
        }
        level.SetActive(false);
    }

    IEnumerator Corotiens()
    {
        yield return new WaitForSeconds(100);
    }
}
