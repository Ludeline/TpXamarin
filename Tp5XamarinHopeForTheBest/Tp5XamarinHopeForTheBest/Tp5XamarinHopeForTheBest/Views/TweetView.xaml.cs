using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5XamarinHopeForTheBest.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tp5XamarinHopeForTheBest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetView : ContentView
    {
        public TweetView()
        {
            InitializeComponent();
        }

        public TweetView LoadData(Tweet item)
        {
            this.Author.Text = item.PseudoUser;
            this.Data.Text = item.Texte;
            this.Email.Text = item.IdUser;
            this.LastUpdate.Text = item.DateCreation;

            return this;
        }
    }
}