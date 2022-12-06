using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToPool : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Selecting")
        {
            SceneManager.LoadScene("Pool");
        }
    }
}
