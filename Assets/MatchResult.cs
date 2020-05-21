using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using RPS;

public class MatchResult : MonoBehaviour
{
    private Score score = null;
    private IAI ai = null;

    Text figure1 = null;
    Text figure2 = null;
    Text result = null;

    Action next;

    // Start is called before the first frame update

    void Start()
    {
        figure1 = transform.Find("Selection1").GetComponent<Text>();
        figure2 = transform.Find("Selection2").GetComponent<Text>();
        result = transform.Find("Result").GetComponent<Text>();

        SetNext(()=>
        {
            gameObject.SetActive(false);
        });
    }

    private string GestureToString(Gestures g)
    {
        if(g==Gestures.P)
        {
            return "PAPER";
        }
        else if (g == Gestures.R)
        {
            return "ROCK";
        }
        else if (g == Gestures.S)
        {
            return "SCISSORS";
        }
        return "*%&#*&$(#*%7";
    }

    internal void UserInput(Gestures g)
    {

        Gestures aiGesture = ai.MakeDecision(g);

        figure1.text = GestureToString(g);
        figure2.text = GestureToString(aiGesture);

        result.text = "UNKNOWN";
        if (RPSRules.FirstBeatsSecond(g, aiGesture))
        {
            result.text = "WON";
            score.addP1();
        }
        else if(RPSRules.FirstBeatsSecond(aiGesture, g))
        {
            result.text = "LOST";
            score.addP2();
        }
        else if(RPSRules.IsDraw(aiGesture, g))
        {
            result.text = "DRAW";
        }

        gameObject.SetActive(true);
    }

    internal void SetScore(Score _score)
    {
        score = _score;
    }

    internal void SetAI(IAI _ai)
    {
        ai = _ai;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void SetNext(Action t)
    {
        next += t;
        
    }

    internal void Next()
    {
        next();
    }

}
