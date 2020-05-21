using RPS;

interface IAI
{
    Gestures MakeDecision(Gestures g);
}

class AISimple : IAI
{
    public Gestures MakeDecision(Gestures g)
    {
        return RPSRules.GetRandomGesture();
    }
}
class AIDork : IAI
{
    public Gestures MakeDecision(Gestures g)
    {
        return Gestures.R;
    }
}

class AICheater : IAI
{
    public Gestures MakeDecision(Gestures g)
    {
        //TODO: add some probability
        return RPSRules.GetWinGesture(g);
    }
}