using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectFigure : MonoBehaviour
{
    // Start is called before the first frame update

    Action<RPS.Gestures> onInput;

    void Start()
    {
        SetInputConsumer(g => gameObject.SetActive(false));

    }

    internal void SetInputConsumer(Action<RPS.Gestures> p)
    {
        onInput += p;
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
        onInput(g);
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
