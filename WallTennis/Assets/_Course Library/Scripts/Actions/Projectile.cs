using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Projectile : MonoBehaviour
{
    LivesUI livesUI;

    ScoringSystem scoringSystem;

    public int Lifeloss = 1;

    //public TextMeshProUGUI Lives;

    public void Awake()
    {
        livesUI = GameObject.Find("Lives").GetComponent<LivesUI>();
        scoringSystem = GameObject.Find("Score").GetComponent<ScoringSystem>();
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
        if (other.gameObject.tag == "Target")
        {
            scoringSystem.IncreaseScore(1);
            Destroy(other.gameObject);
        }
    }
}
