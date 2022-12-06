using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToCastle : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Selecting")
        {
            SceneManager.LoadScene("GreatWallScene");
        }
    }
}
