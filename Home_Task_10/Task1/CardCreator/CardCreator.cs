namespace Task_1.CardServises
{
    public static class CardCreator
    {
        public static CreditCard CreateCard(string number)
        {
            string type = DefineCardType(number);
            if (type != null)
            {
                if (Validator.PrimaryValidationOfCardNum(number))
                {
                    return new CreditCard(Int64.Parse(number), type);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        private static string DefineCardType(string number)
        {
            string cardType;
            if (Validator.IsVisaCard(number))
            {
                cardType = "Visa";
            }
            else if (Validator.IsMasterCard(number))
            {
                cardType = "MasterCard";
            }
            else if (Validator.IsAmericanExpressCard(number))
            {
                cardType = "American Express";
            }
            else
            {
                cardType = null;
            }

            return cardType;
        }
    }
}
