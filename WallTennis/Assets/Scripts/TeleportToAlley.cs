using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToAlley : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Selecting")
        {
            SceneManager.LoadScene("Pool");
        }
    }
}
