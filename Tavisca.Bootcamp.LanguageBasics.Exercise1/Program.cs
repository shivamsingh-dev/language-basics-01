using System;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class FixMultiplication
    {
        static void Main(string[] args)
        {
            Test("42*47=1?74", 9);
            Test("4?*47=1974", 2);
            Test("42*?7=1974", 4);
            Test("42*?47=1974", -1);
            Test("2*12?=247", -1);
            Console.ReadKey(true);
        }

        private static void Test(string args, int expected)
        {
            var result = FindDigit(args).Equals(expected) ? "PASS" : "FAIL";
            Console.WriteLine($"{args} : {result}");
        }

        public static int FindDigit(string equation)
        {

            string[] _numbers = equation.Split('*', '=');
            string A = _numbers[0];
            string B = _numbers[1];
            string C = _numbers[2];
            if (A.Contains("?"))
            {
                if (Int32.Parse(C) % Int32.Parse(B) != 0)
                {
                    return -1;
                }
                else
                {
                    string expectedAns = (Int32.Parse(C) / Int32.Parse(B)).ToString();

                    int _index = A.IndexOf("?");
                    if (expectedAns.Substring(0, _index).Equals(A.Substring(0, _index)) && expectedAns.Substring(_index + 1).Equals(A.Substring(_index + 1)))
                    {

                        return expectedAns[_index] - '0';
                    }
                    else
                    { return -1; }
                }
            }
            else if (B.Contains("?"))
            {
                if (Int32.Parse(C) % Int32.Parse(A) != 0)
                {
                    return -1;
                }
                else
                {
                    string expectedAns = (Int32.Parse(C) / Int32.Parse(A)).ToString();

                    int _index = B.IndexOf("?");
                    if (expectedAns.Substring(0, _index).Equals(B.Substring(0, _index)) && expectedAns.Substring(_index + 1).Equals(B.Substring(_index + 1)))
                    {
                        return expectedAns[_index] - '0';
                    }
                    else
                    { return -1; }
                }

            }
            else
            {
                string expectedAns = (Int32.Parse(A) * Int32.Parse(B)).ToString();
                int _index = C.IndexOf("?");
                if (expectedAns.Substring(0, _index).Equals(C.Substring(0, _index)) && expectedAns.Substring(_index + 1).Equals(C.Substring(_index + 1)))
                {

                    return expectedAns[_index] - '0';
                }
                else
                { return -1; }

            }
        }
    }
}
