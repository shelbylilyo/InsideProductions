using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float delta = 1.5f;
    public float speed = 2.0f;
    private Vector3 startPosition;

    public bool leftRight;
    public bool upDown;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (upDown == true)
        {
            Vector3 v = startPosition;
            v.y += delta * Mathf.Sin(Time.time * speed);
            transform.position = v;
        }

        if (leftRight == true)
        {
            Vector3 v = startPosition;
            v.x += delta * Mathf.Sin(Time.time * speed);
            transform.position = v;
        }
    }
}
