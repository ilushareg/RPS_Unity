﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayFlow : MonoBehaviour
{
    SelectFigure sf = null;
    MatchResult mr = null;
    Score score = null;

    // Start is called before the first frame update
    void Start()
    {
        sf = GameObject.Find("SelectFigure").GetComponent<SelectFigure>();

        mr = GameObject.Find("MatchResult").GetComponent<MatchResult>();

        score = GameObject.Find("Score").GetComponent<Score>();

        sf.SetMatchResult(mr);
        mr.SetScore(score);

        IAI ai = new AIDork();
        mr.SetAI(ai);

        sf.GO();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}