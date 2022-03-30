using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace mortage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Mortage : Page
    {
        public Mortage()
        {
            this.InitializeComponent();
        }

        private async void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double principal, years, months, yearlyInterestRate, monthlyInterestRate, monthlyRepayment, andmonths;

            principal = double.Parse(principalTextBox.Text);
            years = double.Parse(yearsTextBox.Text);
            yearlyInterestRate = double.Parse(yearlyInterestRateTextBox.Text);

            if (andMonthsTextBox.Text == "")
            {
                andMonthsTextBox.Text = "0";
            }
            try
            {
                andmonths = double.Parse(andMonthsTextBox.Text);
            }
            catch (FormatException)
            {
                var dialogMessage = new MessageDialog("Error Please input the valid months");
                await dialogMessage.ShowAsync();
                andMonthsTextBox.Focus(FocusState.Programmatic);
                andMonthsTextBox.SelectAll();
                return;
            }
            if (monthlyInterestRateTextBox.Text == "")
            {
                monthlyInterestRate = (yearlyInterestRate / 100) / 12;

                monthlyInterestRateTextBox.Text = monthlyInterestRate.ToString();
            }

            months = ((years * 12) + andmonths);
            monthlyInterestRate = (yearlyInterestRate / 100) / 12;


            monthlyRepayment = principal * (monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, months)) /
                ((Math.Pow(1 + monthlyInterestRate, months)) - 1);
            monthlyInterestRateTextBox.Text = monthlyInterestRate.ToString("P");
            monthlyRepaymentTextBox.Text = monthlyRepayment.ToString("C");
            andMonthsTextBox.Text = andmonths.ToString();
        }
    }
}
