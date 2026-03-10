using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advance
{
    public class TruthLiarPuzzle
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Truth Liar Puzzle");

            bool isTruth = true;
            isTruth = IsConsistent(true, false, false);

            Console.WriteLine(isTruth);
        }

        private static bool IsConsistent(bool p1, bool p2, bool p3)
        {
            bool statementA = (p1 == false);
            bool statementB = (p2 == false);
            bool statementC = (p3 == true);

            if (p1 && !statementA) return false;
            if (!p1 && statementA) return false;

            if (p2 && !statementB) return false;
            if (!p2 && statementB) return false;

            if (p3 && !statementC) return false;
            if (!p3 && statementC) return false;

            return true;
        }
    }
}