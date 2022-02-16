using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MainMenu_Prototype
{
    public class PassMethods
    {
        public static int checkPassStrength(string pass)
        {
            int strength = 0;
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            if (hasMinimum8Chars.IsMatch(pass) == true)
            {
                if (hasNumber.IsMatch(pass) == true & hasUpperChar.IsMatch(pass) == true)
                {
                    if (hasSymbols.IsMatch(pass) == true)
                    {
                        strength = 4;
                    }
                    else
                    {
                        strength = 3;
                    }
                }
                else
                {
                    strength = 2;
                }

            }
            else
            {
                if (hasNumber.IsMatch(pass) == true & hasUpperChar.IsMatch(pass) == true)
                {
                    strength = 1;
                }
                else
                {
                    strength = 0;
                }
            }

            return strength;
        }
    }
}
