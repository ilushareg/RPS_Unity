using RPS;

interface IAI
{
    Gestures MakeDecision(Gestures gOpponent);
}

class AISimple : IAI
{
    public Gestures MakeDecision(Gestures gOpponent)
    {
        return RPSRules.GetRandomGesture();
    }
}
class AIDork : IAI
{
    public Gestures MakeDecision(Gestures gOpponent)
    {
        return Gestures.R;
    }
}

class AICheater : IAI
{
    public Gestures MakeDecision(Gestures gOpponent)
    {
        //TODO: make not so clever
        return RPSRules.GetWinGesture(gOpponent);
    }
}