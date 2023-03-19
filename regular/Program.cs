using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace regular
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            string str1 = "ahb acb aeb aeeb adcb axeb";
            Regex regex1 = new Regex(@"a.b");
            MatchCollection matches1 = regex1.Matches(str1);
            foreach (Match match in matches1)
            {
                Console.WriteLine(match.Value);
            }
            #endregion
            #region 2
            string str2 = "aba aca aea abba adca abea";
            Regex regex2 = new Regex(@"a..a");
            MatchCollection matches2 = regex2.Matches(str2);
            foreach (Match match in matches2)
            {
                Console.WriteLine(match.Value);
            }
            #endregion
            #region 3
            string str3 = "aba aca aea abba adca abea";
            Regex regex3 = new Regex(@"ab(a|e)a");
            MatchCollection matches3 = regex3.Matches(str3);
            foreach (Match match in matches3)
            {
                Console.WriteLine(match.Value);
            }
            #endregion
            #region 4
            string str4 = "aa aba abba abbba abca abea";
            Regex regex4 = new Regex(@"ab*a");
            MatchCollection matches4 = regex4.Matches(str4);
            foreach (Match match in matches4)
            {
                Console.WriteLine(match.Value);
            }
            #endregion
            #region 5
            string str5 = "aa aba abba abbba abca abea";
            Regex regex5 = new Regex(@"ab?a");
            MatchCollection matches5 = regex5.Matches(str5);
            foreach (Match match in matches5)
            {
                Console.WriteLine(match.Value);
            }
            #endregion
            #region 6
            string str6 = "aa aba abba abbba abca abea";
            Regex regex6 = new Regex(@"ab+a");
            MatchCollection matches6 = regex6.Matches(str6);
            foreach (Match match in matches6)
            {
                Console.WriteLine(match.Value);
            }
            #endregion
            #region 7
            string str7 = "aa aba abba abbba abca abea";
            Regex regex7 = new Regex(@"a.b.a");
            MatchCollection matches7 = regex7.Matches(str7);
            foreach (Match match in matches7)
            {
                Console.WriteLine(match.Value);
            }
            #endregion
            #region 8
            string str8 = "ab abab abab abababab abea";
            Regex regex8 = new Regex(@"a+");
            MatchCollection matches8 = regex8.Matches(str8);
            foreach (Match match in matches8)
            {
                Console.WriteLine(match.Value);
            }
            Console.ReadLine();
            #endregion
        }
    }
}