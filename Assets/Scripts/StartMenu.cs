using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public void ActivateObj(GameObject name)
    {
        name.SetActive(true);
    }

    public void ActivateScript(GameObject objectWithScripts)
    {
        SpainBombs spain = objectWithScripts.GetComponent<SpainBombs>();
        spain.enabled = true;
        Score score = objectWithScripts.GetComponent<Score>();
        score.enabled = true;
    }

    public void offButton(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

}
