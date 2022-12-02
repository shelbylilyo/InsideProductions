using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBallSpawn : MonoBehaviour
{
    LivesUI livesUI;

    ScoringSystem scoringSystem;

    LaunchProjectile launchProjectile;

    //public GameObject Launcher;

    public int Lifeloss = 1;

    //public TextMeshProUGUI Lives;

    public void Awake()
    {
        livesUI = GameObject.Find("Lives").GetComponent<LivesUI>();
        scoringSystem = GameObject.Find("Score").GetComponent<ScoringSystem>();
        launchProjectile = GameObject.Find("Launcher_Dart").GetComponent<LaunchProjectile>();
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
            launchProjectile.Fire();
        }
        if (other.gameObject.tag == "Target")
        {
            scoringSystem.IncreaseScore(1);
            Destroy(other.gameObject);
        }
    }
}
