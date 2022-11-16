using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CesarProjectile : MonoBehaviour
{
    LivesUI livesUI;

    LaunchProjectile launchProjectile;

    CesarBallSpwaner cesarBallSpwaner;

    public int Lifeloss = 1;

    // Start is called before the first frame update
    void Start()
    {
        launchProjectile = GameObject.Find("Cannon").GetComponent<LaunchProjectile>();
        livesUI = GameObject.Find("Lives").GetComponent<LivesUI>();
        cesarBallSpwaner = GameObject.Find("Table").GetComponent<CesarBallSpwaner>();
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Background")
        {
            Destroy(gameObject);
            cesarBallSpwaner.SpwanBall();
            livesUI.DecreaseLife(Lifeloss);
        }
        if (other.gameObject.tag == "100P")
        {
            launchProjectile.Fire();
        }
        if (other.gameObject.tag == "200P")
        {
            launchProjectile.Fire();
        }
        if (other.gameObject.tag == "360P")
        {
            launchProjectile.Fire();
        }
        if (other.gameObject.tag == "500P")
        {
            launchProjectile.Fire();
        }
        if (other.gameObject.tag == "1000P")
        {
            launchProjectile.Fire();
        }
        if (other.gameObject.tag == "1500")
        {
            launchProjectile.Fire();
        }
        if (other.gameObject.tag == "2000P")
        {
            launchProjectile.Fire();
        }
    }
}
