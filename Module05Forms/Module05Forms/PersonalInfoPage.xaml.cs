using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module05Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonalInfoPage : ContentPage
    {
        public PersonalInfoPage()
        {
            InitializeComponent();
        }
        private void MSwitchToggled(object sender, ToggledEventArgs e)
        {
            MiddleName.IsEnabled = e.Value;
        }
        private void SelectDate (object sender, DateChangedEventArgs e) 
        { 
            var tday = DateTime.Today;

            var age = tday.Year - birthDate.Date.Year;

            if (birthDate.Date > tday.AddYears(-age)) age--;

            Age.Text = $"Age:{age}";
        }
        private void ClickIfFull(object sender, EventArgs e)
        {
            ResultIsDisplayed();
        }

        private void ResultIsDisplayed()
        {
            string result = $"First Name: {FirstName.Text}\n" +

                            $"Middle Name: {(SMiddleName.IsToggled ? MiddleName.Text : "N/A")}\n" +

                            $"Last Name: {LastName.Text}\n" +

                            $"Gender: {Gender.SelectedItem}\n" +

                            $"BirthDate: {birthDate.Date.ToString("d")}\n" +

                            $"Address: {Address.Text}\n" +

                            $"Contact Number: {ContactNumeber.Text}\n" +

                            $"Email: {Email.Text}\n" +

                            $"Username: {Username.Text}\n" +

                            $"Password: {new String('*', Password.Text.Length)}";

            DisplayAlert("Form Submission", result, "Ok");

        }                   

    }
}