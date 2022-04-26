﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CristhianMotocheExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void BtnAbrir_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro(TxtUsuario.Text, TxtPass.Text));

        }

    }
}