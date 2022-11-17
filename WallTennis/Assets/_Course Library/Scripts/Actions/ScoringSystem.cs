using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public TextMeshProUGUI PScore;

    public int Score = 0;

    // Start is called before the first frame update
    void Awake()
    {
        PScore = PScore.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frames
    void Update()
    {
        PScore.text = "Score: " + Score.ToString();
    }

    public void IncreaseScore(int Scoreincrease)
    {
        Score += Scoreincrease;
        PScore.text = "Score: " + Score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        IncreaseScore(1);
    }
}