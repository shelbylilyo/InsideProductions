using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour
{
    public TextMeshProUGUI PLives;

    public int Lives = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        PLives = PLives.GetComponent<TextMeshProUGUI>();
    }
    // Update is called once per frame
    void Update()
    {
        PLives.text = "Lives: " + Lives.ToString();
    }

    public void DecreaseLife(int Lifeloss)
    {
        Lives = Lives - Lifeloss;
        PLives.text = "Lives: " + Lives.ToString();
    }
}
