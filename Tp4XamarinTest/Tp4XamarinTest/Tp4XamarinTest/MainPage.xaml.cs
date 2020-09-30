using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp4XamarinTest.Services;
using Xamarin.Forms;

namespace Tp4XamarinTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine("Test dans le main");
            Console.ReadLine();
            this.Connexion.Clicked += Connexion_Clicked;
        }

        private void Connexion_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Coucou voici le TP3 en Xamarin");
            Console.ReadLine();

            if (this.Mail.Text.Length < 3 && this.Mail.Text != null)
            {
                this.Errors.IsVisible = true;
                this.Errors.Text = "Votre mail n'est pas bon.";
            }

            if (this.Password.Text.Length < 6 && this.Password.Text != null)
            {
                this.Errors.IsVisible = true;
                this.Errors.Text = "Votre MDP n'est pas bon.";
            }

            if (this.Mail.Text.Length >= 3 && this.Password.Text.Length >= 6)
            {
                //this.Vue.IsVisible = true;
            }
        }
    }
}
