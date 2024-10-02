using System;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Call(string phoneNumber)
        {
            if (!ValidatePhoneNumber(phoneNumber))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Dialing... {phoneNumber}";
        }
        private bool ValidatePhoneNumber(string phoneNumber)
        {
            return phoneNumber.All(char.IsDigit); // without lambda expression
        }
    }
}

