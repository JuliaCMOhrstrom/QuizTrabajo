using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Quiz
{
    public partial class MainPage : ContentPage
    { 
        public MainPage()
        {
            InitializeComponent();
        }

        async void es(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Espanol());
        }
        private async void btnMa_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Matematicas());
        }
        private async void btnHi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Historia());
        }
        private async void btnGe_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Geografia());
        }



    }
}
