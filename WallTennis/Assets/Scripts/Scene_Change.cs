using System.ComponentModel.Design.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Change : MonoBehaviour
{
    [SerializeField]
    private string SceneName;

    [SerializeField]
    private TextMeshPro MapName;

    [SerializeField]
    private string Tag;

    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == tag)
        {
            SceneManager.LoadScene(SceneName);
        }

        if (target.tag == tag)
        {
            SceneManager.LoadScene(SceneName);
        }
    }

    void Start()
    {
        MapName.text = SceneName;
    }
}
