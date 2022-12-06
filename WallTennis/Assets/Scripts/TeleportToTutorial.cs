using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToTutorial : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Selecting")
        {
            SceneManager.LoadScene("Tutorial");
        }
    }
}