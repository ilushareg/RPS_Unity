using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectFigure : MonoBehaviour
{
    // Start is called before the first frame update
    MatchResult mr = null;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void Rock()
    {
        DoInput(RPS.Gestures.R);
    }
    internal void Paper()
    {
        DoInput(RPS.Gestures.P);
    }
    internal void Scissors()
    {
        DoInput(RPS.Gestures.S);
    }

    private void DoInput(RPS.Gestures g)
    {
        mr.UserInput(g);
        gameObject.SetActive(false);
    }

    internal void SetMatchResult(MatchResult _mr)
    {
        mr = _mr;
    }

    internal void GO()
    {
        transform.gameObject.SetActive(true);

    }

    internal void StartSelecting()
    {
        gameObject.SetActive(true);
    }
}
