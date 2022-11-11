using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Projectile : MonoBehaviour
{
    LivesUI livesUI;

    public int Lifeloss = 1;

    public TextMeshProUGUI Lives;

    public void Awake()
    {
        livesUI = Lives.GetComponent<LivesUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Background")
        {
            livesUI.DecreaseLife(Lifeloss);
            Destroy(gameObject);
        }
    }
}
