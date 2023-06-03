namespace Task_1.CardServises
{
    public class CreditCard
    {
        private Int64 _number;
        private string _type;

        public Int64 Number { get { return _number; } }
        public string Type { get { return new string(_type); } }
        internal CreditCard(Int64 cardNumber, string type)
        {
            _number = cardNumber;
            _type = new string(type);
        }

        public override string ToString()
        {
            return $"# {_type} # card_number = “{_number}”";
        }
    }
}
