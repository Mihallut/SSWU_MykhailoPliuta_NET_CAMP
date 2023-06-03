namespace Task_1.CardServises
{
    public static class Validator
    {
        private static bool IsCardNumCorrect(string cardNumber)
        {
            bool isCorrect = false;
            if (cardNumber != null)
            {
                if (cardNumber.All(char.IsDigit))
                {
                    isCorrect = true;
                }
            }
            return isCorrect;
        }

        public static bool IsVisaCard(string cardNumber)
        {
            bool isVisaCard = false;
            if (IsCardNumCorrect(cardNumber))
            {
                if (Constants.VisaStartNums.Any(num => cardNumber.StartsWith(num)))
                {
                    isVisaCard = true;
                }
            }
            return isVisaCard;
        }

        public static bool IsMasterCard(string cardNumber)
        {
            bool isVisaCard = false;
            if (IsCardNumCorrect(cardNumber))
            {
                if (Constants.MasterCardStartNums.Any(num => cardNumber.StartsWith(num)))
                {
                    isVisaCard = true;
                }
            }
            return isVisaCard;
        }

        public static bool IsAmericanExpressCard(string cardNumber)
        {
            bool isVisaCard = false;
            if (IsCardNumCorrect(cardNumber))
            {
                if (Constants.AmericanExpressStartNums.Any(num => cardNumber.StartsWith(num)))
                {
                    isVisaCard = true;
                }
            }
            return isVisaCard;
        }

        public static bool PrimaryValidationOfCardNum(string cardNumber)
        {
            bool isValid = false;
            if (IsCardNumCorrect(cardNumber))
            {
                int[] digits = cardNumber.ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();
                for (int i = digits.Length - 2; i >= 0; i = i - 2)
                {
                    int doubling = digits[i] * 2;
                    int sum = doubling / 10 + doubling % 10;
                    digits[i] = sum;
                }
                int digitsSum = digits.Sum();
                if (digitsSum % 10 == 0)
                {
                    isValid = true;
                }
            }

            return isValid;
        }

    }
}
