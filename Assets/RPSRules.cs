using System;
using System.Diagnostics;

namespace RPS
{
    public enum Gestures
    {
        R,
        P,
        S
    };
    public class RPSRules
    {

        private static Gestures[][] wincombinations = new Gestures[][] {
            new Gestures[2] { Gestures.P, Gestures.R },
            new Gestures[2] { Gestures.R, Gestures.S },
            new Gestures[2] { Gestures.S, Gestures.P }};

        public static Gestures GetWinGesture(Gestures g)
        {
            for (int i = 0; i < wincombinations.Length; i++)
            {
                if (wincombinations[i][0] == g)
                {
                    return wincombinations[i][1];
                }
            }

            throw new ArgumentException("unreachable code");
        }

        public static Gestures GetRandomGesture()
        {
            Array values = Enum.GetValues(typeof(Gestures));
            Random random = new Random();
            Gestures rand = (Gestures)values.GetValue(random.Next(values.Length));
            return rand;
        }

        public static bool IsDraw(Gestures g1, Gestures g2)
        {

            return g1 == g2;
        }

        public static bool FirstBeatsSecond(Gestures g1, Gestures g2)
        {
            for (int i = 0; i < wincombinations.Length; i++)
            {
                if (wincombinations[i][0] == g1)
                {
                    return wincombinations[i][1] == g2;
                }
            }
            return false;
        }

        [Conditional("TEST_RULES_CODE")]
        public static void testRules()
        {
            Debug.Assert(FirstBeatsSecond(Gestures.P, Gestures.R));
            Debug.Assert(!FirstBeatsSecond(Gestures.P, Gestures.S));
            Debug.Assert(!FirstBeatsSecond(Gestures.P, Gestures.P));
            Debug.Assert(!IsDraw(Gestures.P, Gestures.S));
            Debug.Assert(IsDraw(Gestures.S, Gestures.S));
            Console.WriteLine("RPS tests complete");
        }

    }

}
