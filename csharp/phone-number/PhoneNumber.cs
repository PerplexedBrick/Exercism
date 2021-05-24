using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {

        phoneNumber = Regex.Replace(phoneNumber, "[^0-9]", "");

        if (phoneNumber.Length < 10 || phoneNumber.Length > 11) throw new ArgumentException("Incorrect number of digits");
        if (phoneNumber.Length == 11 && phoneNumber[0] != '1') throw new ArgumentException("Phone number in a full format cant start only with 1");

        phoneNumber = phoneNumber.Substring(phoneNumber.Length - 10);

        if (Regex.IsMatch(phoneNumber[0].ToString(), "[2-9]") && Regex.IsMatch(phoneNumber[3].ToString(), "[2-9]"))
        {
            return phoneNumber;
        }
        else throw new ArgumentException("Wrong format. Please check for mistakes in the given number");

    }
}