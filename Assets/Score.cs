using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text score = null;
    private int p1 = 0;
    private int p2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = transform.GetComponentInChildren<Text>();
        UpdateScore();
    }

    private void UpdateScore()
    {
        score.text = p1 + ":" + p2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void addP1()
    {
        p1 += 1;
        UpdateScore();
    }
    internal void addP2()
    {
        p2 += 1;
        UpdateScore();
    }

}
