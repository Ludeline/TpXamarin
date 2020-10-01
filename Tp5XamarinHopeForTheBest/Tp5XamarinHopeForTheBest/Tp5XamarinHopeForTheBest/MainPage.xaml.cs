﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5XamarinHopeForTheBest.Services;
using Tp5XamarinHopeForTheBest.Views;
using Xamarin.Forms;

namespace Tp5XamarinHopeForTheBest
{
    public partial class MainPage : ContentPage
    {
        private IService twitterService;
        public MainPage()
        {
            InitializeComponent();
            this.twitterService = new TwitterService();
            System.Diagnostics.Debug.WriteLine("Test dans le main");
            Console.ReadLine();
            this.Connexion.Clicked += Connexion_Clicked;
            this.LoadTweets(this.StacklayoutTweets);
        }
        //Solution affichage Antoine C
        private void LoadTweets(StackLayout stacklayoutTweets)
        {
            foreach (var item in twitterService.GetTweets())
            {
                stacklayoutTweets.Children.Add(new TweetView().LoadData(item));
            }
        }
        //Fin de solution d'Antoine

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

            //Connectivité
            if(Xamarin.Essentials.Connectivity.NetworkAccess == Xamarin.Essentials.NetworkAccess.Internet)
            {
                if (this.Mail.Text.Length >= 3 && this.Password.Text.Length >= 6 && this.twitterService.Authentificate(this.Mail.Text, this.Password.Text))
                {

                    this.Vue.IsVisible = true;
                    this.FormulaireConnexion.IsVisible = false;
                    this.Errors.IsVisible = false;
                }
                else
                {
                    this.Errors.IsVisible = true;
                    this.Errors.Text = "Vos identifiants ne sont pas bons";
                }
            }
        }
    }
}