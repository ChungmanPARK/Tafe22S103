using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace currency
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class currencyCalculaor : Page
    {
        public currencyCalculaor()
        {
            this.InitializeComponent();
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            double amount;
            amount = double.Parse(AmountTextBox.Text);
            double conversion;

            if (FromComboBox.SelectedIndex == 0)
            {
                if (ToComboBox.SelectedIndex == 1)
                {
                    conversion = CalToEuroFromUS(amount);
                    ConversionTextBox.Text = "€" + conversion.ToString() + "\n" + "1 USD = 0.85189982 EURO" + "\n" + "1 EURO = 1.1739732 USDOLLAR";
                }

                else if (ToComboBox.SelectedIndex == 2)
                {

                    conversion = CalToPoundFromUS(amount);
                    ConversionTextBox.Text = "£" + conversion.ToString() + "\n" + "1 USD = 0.72872436 British Pound" +"\n" + "1 Pound = 1.371907 USDOLLAR";
                }

                else if (ToComboBox.SelectedIndex == 3)
                {
                    conversion = CalToRupeeFromUS(amount);
                    ConversionTextBox.Text = "₹" + conversion.ToString() + "\n" + "1 USD = 74.257327 Rupee" + "\n" + "1 Rupee = 0.011492628 USDOLLAR";
                }
            }

            if (FromComboBox.SelectedIndex == 1)
            {
                if (ToComboBox.SelectedIndex == 0)
                {
                    conversion = CalToUSFromEuro(amount);
                    ConversionTextBox.Text = "$" + conversion.ToString() + "\n" + "1 Euro = 1.1739732 US Dollar" + "\n" + "1 USD = 0.85189982 Euro";
                }
                else if (ToComboBox.SelectedIndex == 2)
                {
                    conversion = CalToPoundFromEuro(amount);
                    ConversionTextBox.Text = "£" + conversion.ToString() + "\n" + "1 Euro = 0.8556672 Pound" + "\n" + "1 Pound = 1.1686692 Euro";
                }
                else if (ToComboBox.SelectedIndex == 3)
                {
                    conversion = CalToRupeeFromEuro(amount);
                    ConversionTextBox.Text = "₹" + conversion.ToString() + "\n" + "1 Euro = 87.00755 Rupee" + "\n" + "1 Rupee = 0.013492774 Euro"; 
                }
            }

            if (FromComboBox.SelectedIndex == 2)
            {
                if (ToComboBox.SelectedIndex == 0)
                {
                    conversion = CalToUSFromPound(amount);
                    ConversionTextBox.Text = "$" + conversion.ToString() + "\n" + "1 Pound = 1.371907 USD" + "\n" + "1 USD = 0.72872436 Pound";
                }
                else if (ToComboBox.SelectedIndex == 1)
                {
                    conversion = CalToEuroFromPound(amount);
                    ConversionTextBox.Text = "€" + conversion.ToString() + "\n" + "1 Pound = 1.1686692 Euro" + "\n" + "1 Euro = 0.8556672 Pound";
                }
                else if (ToComboBox.SelectedIndex == 3)
                {
                    conversion = CalToRupeeFromPound(amount);
                    ConversionTextBox.Text = "₹" + conversion.ToString() + "\n" + "1 Pound = 101.68635 Rupee" + "\n" + "1 Rupee = 0.0098339397 Pound";
                }
            }
            if (FromComboBox.SelectedIndex == 3)
            {
                if (ToComboBox.SelectedIndex == 0)
                {
                    conversion = CalToUSDollarFromRupee(amount);
                    ConversionTextBox.Text = "$" + conversion.ToString() + "\n" + "1 Rupee = 0.011492628 USD" + "\n" + "1 USD = 74.257327 Rupee";
                }
                else if (ToComboBox.SelectedIndex == 1)
                {
                    conversion = CalToEuroFromRupee(amount);
                    ConversionTextBox.Text = "€" + conversion.ToString() + "\n" + "1 Rupee = 0.013492774 Euro" + "\n" + "1 Euro = 87.00755 Rupee";
                }
                else if (ToComboBox.SelectedIndex == 2)
                {
                    conversion = CalToPoundFromRupee(amount);
                    ConversionTextBox.Text = "£" + conversion.ToString() + "\n" + "1 Rupee = 0.0098339397 Pound" + "\n" + "1 Pound = 101.68635 Rupee";
                }
            }

        }
        /* FOR US DOLLAR*/
        private double CalToEuroFromUS(double amount)
        {
            const double euro = 0.85189982;
            double total;

            total = euro * amount;
            return total;
        }

        private double CalToPoundFromUS(double amount)
        {
            const double pound = 0.72872436;
            double total;

            total = pound * amount;
            return total;
        }

        private double CalToRupeeFromUS(double amount)
        {
            const double Rupee = 74.257327;
            double total;

            total = Rupee * amount;
            return total;
        }

        /* FOR EURO */
        private double CalToUSFromEuro(double amount) 
        {
            const double USDollar = 1.1739732;
            double total;

            total = USDollar * amount;
            return total;
        }

        private double CalToPoundFromEuro(double amount) 
        {
            const double Pound = 0.8556672;
            double total;

            total = Pound * amount;
            return total;
        }

        private double CalToRupeeFromEuro(double amount) 
        {
            const double Rupee = 87.00755;
            double total;

            total = Rupee * amount;
            return total;
        }

        /*For Pound*/

        private double CalToUSFromPound(double amount) 
        {
            const double USDollar = 1.371907;
            double total;

            total = USDollar * amount;
            return total;
        }

        private double CalToEuroFromPound(double amount) 
        {
            const double Euro = 1.1686692;
            double total;

            total = Euro * amount;
            return total;
        }

        private double CalToRupeeFromPound(double amount) 
        {
            const double Rupee = 101.68635;
            double total;

            total = Rupee * amount;
            return total;
        }

        /*For Rupee*/

        private double CalToUSDollarFromRupee(double amount) 
        {
            const double USDollar = 0.011492628;
            double total;

            total = USDollar * amount;
            return total;
        }

        private double CalToEuroFromRupee(double amount) 
        {
            const double Euro = 0.013492774;
            double total;

            total = Euro * amount;
            return total;
        }

        private double CalToPoundFromRupee(double amount) 
        {
            const double Pound = 0.0098339397;
            double total;

            total = Pound * amount;
            return total;
        }


    }
}
