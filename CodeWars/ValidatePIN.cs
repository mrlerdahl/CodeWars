using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class ValidatePIN
    {
        // ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.
       // If the function is passed a valid PIN string, return true, else return false.
        public static bool ValidatePin(string pin)
        {
            bool pinVal = false;
            int x = 0;

            if (!int.TryParse(pin, out x))
            {
                return false;
            }
       
            if (pin.Contains(" ") || pin.Contains("-") || pin.Contains("\n") || pin.Contains("+"))
            {
                return false;
            }
            if (pin.Length == 4)
            {
                return true;
            }
            if (pin.Length == 6)
                return true;

            return pinVal;
        }
    }
}
