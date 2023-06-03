using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Task_1.CardServises;

namespace Task_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            string cardNumber = new string(textBoxCreditCard.Text.Where(c => char.IsDigit(c)).ToArray());
            CardCreator cardCreator = new CardCreator();
            CreditCard creditCard = cardCreator.CreateCard(cardNumber);
            if (creditCard != null)
            {
                textBlockResult.Text = creditCard.ToString();
            }
            else
            {
                textBlockResult.Text = "Card number is incorrect!";

            }
        }

        private void textBoxCreditCard_TextChanged(object sender, TextChangedEventArgs e)
        {

            // Удалить все символы, кроме цифр из текста

            string rawNumber = new string(textBoxCreditCard.Text.Where(c => char.IsDigit(c)).ToArray());

            // Форматирование номера карты 
            if (Validator.IsAmericanExpressCard(rawNumber))
            {
                // Форматирование номера карты в стандарте American Express
                textBoxCreditCard.Text = FormatAsAmericanExpress(rawNumber);
            }
            else
            if (Validator.IsVisaCard(rawNumber) || Validator.IsMasterCard(rawNumber))
            {
                textBoxCreditCard.Text = FormatAsVisaOrMastercard(rawNumber);
            }
            else
            {
                textBoxCreditCard.Text = rawNumber;
            }


            textBoxCreditCard.Focus();
            textBoxCreditCard.CaretIndex = textBoxCreditCard.Text.Length;
        }

        private static string FormatAsVisaOrMastercard(string cardNumber)
        {
            string formattedNumber = "";
            if (cardNumber.Length <= 16)
            {
                for (int i = 0; i < cardNumber.Length; i++)
                {
                    if (i > 0 && i % 4 == 0)
                    {
                        formattedNumber += " ";
                    }
                    formattedNumber += cardNumber[i];
                }
            }
            else
            {
                formattedNumber = cardNumber.Substring(0, cardNumber.Length - 1);
            }
            return formattedNumber;
        }

        private string FormatAsAmericanExpress(string cardNumber)
        {
            string formattedNumber = "";

            if (cardNumber.Length <= 15)
            {
                for (int i = 0; i < cardNumber.Length; i++)
                {
                    if (i == 4 || i == 10)
                    {
                        formattedNumber += " ";
                    }

                    formattedNumber += cardNumber[i];
                }
            }
            else
            {
                formattedNumber = cardNumber.Substring(0, cardNumber.Length - 1);
            }
            return formattedNumber;
        }
    }
}
