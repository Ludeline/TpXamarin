using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Test8242Tp3Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Connexion.Clicked += Connexion_Clicked;
        }

        private void Connexion_Clicked(object sender, EventArgs e)
        {

            if(this.Mail.Text.Length < 3 && this.Mail.Text != null)
            {
                this.Errors.IsVisible = true;
                this.Errors.Text = "Votre mail n'est pas bon.";
            }

            if(this.Password.Text.Length < 6 && this.Password.Text != null)
            {
                this.Errors.IsVisible = true;
                this.Errors.Text = "Votre MDP n'est pas bon.";
            }

            if(this.Mail.Text.Length >= 3 && this.Password.Text.Length >= 6)
            {
                this.Vue.IsVisible = true;
            }
        }
    }
}
