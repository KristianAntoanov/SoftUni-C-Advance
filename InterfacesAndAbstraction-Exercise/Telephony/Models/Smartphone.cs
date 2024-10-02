using System;
using System.Text.RegularExpressions;
using Telephony.Models.Interfaces;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Call(string phoneNumber)
        {
            if (!ValidatePhoneNumber(phoneNumber))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Calling... {phoneNumber}";
        }
        public string Browse(string url)
        {
            if (!ValidateUrl(url))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {url}!";
        }
        private bool ValidatePhoneNumber(string phoneNumber)
        {
            return phoneNumber.All(char.IsDigit); // without lambda expression
        }
        private bool ValidateUrl(string url)
        {
            return url.All(x => !char.IsDigit(x)); // with lambda expression
        }
    }
}