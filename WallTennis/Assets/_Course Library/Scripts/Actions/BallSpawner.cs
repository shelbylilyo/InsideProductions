using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField]
    public float BallTimer = 5f;

    public float TimerReset = 5f;

    public GameObject Launcher;

    LaunchProjectile launchProjectile;

    // Start is called before the first frame update
    void Start()
    {
        launchProjectile = Launcher.GetComponent<LaunchProjectile>();
    }

    // Update is called once per frame
    void Update()
    {
        BallTimer -= Time.deltaTime;

        if (BallTimer <= 0)
        {
            launchProjectile.Fire();
            BallTimer = TimerReset;
        }
    }
}
