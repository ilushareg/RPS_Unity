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

    public void Rock()
    {
        mr.UserInput(RPS.Gestures.R);
    }
    public void Paper()
    {
        mr.UserInput(RPS.Gestures.P);
    }
    public void Scissors()
    {
        mr.UserInput(RPS.Gestures.S);
    }

    internal void SetMatchResult(MatchResult _mr)
    {
        mr = _mr;
    }

    internal void GO()
    {
        mr.hide();
        transform.gameObject.SetActive(true);

    }
}
