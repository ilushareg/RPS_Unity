using System;
using RPS;

public interface IAI
{
    public Gestures MakeDecision(RPS.Gestures g);
}

public class AIDork : IAI
{
    public Gestures MakeDecision(Gestures g)
    {
        return Gestures.R;
    }
}

public class AISimple : IAI
{
    public Gestures MakeDecision(Gestures g)
    {
        return RPSRules.GetRandomGesture();
    }
}

public class AIClever : IAI
{
    public Gestures MakeDecision(Gestures g)
    {
        return RPSRules.GetWinGesture(g);
    }
}
