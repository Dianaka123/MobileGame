using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Main");
    }
}
