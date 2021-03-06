﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void LoginBtn_Clicked(object sender, EventArgs e) //Evento de boton Log in click//
        {
            if(string.IsNullOrEmpty(EntUserName.Text) || string.IsNullOrEmpty(EntPass.Text))
            {
                await DisplayAlert("Mensaje","Campos Vacios","Ok");
            }
            else
            {
                await DisplayAlert("Mensaje", $"Registrado {EntUserName.Text}", "Ok");
                EntUserName.Text = string.Empty;
                EntPass.Text = string.Empty;
            }
        }

        private async void SignUp_Clicked(object sender, EventArgs e)  //Evento de boton Sign Up click//
        {
            if (string.IsNullOrEmpty(NewEmail.Text) || string.IsNullOrEmpty(NewUser.Text) || string.IsNullOrEmpty(NewPass.Text) || string.IsNullOrEmpty(ConfirmPass.Text))
            {
                await DisplayAlert("Mensaje", "Campos Vacios", "Ok");                
            }
            else
            {
                if (ConfirmPass.Text != NewPass.Text)
                {
                    await DisplayAlert("Mensaje", "La contraseña no coincide", "Ok");
                }
                else
                {
                    await DisplayAlert("Bienvenido", $"Registrado {EntUserName.Text}", "Ok");
                    NewPass.Text = string.Empty;
                    NewEmail.Text = string.Empty;
                    NewUser.Text = string.Empty;
                    ConfirmPass.Text = string.Empty;
                }                
            }
        }
    }
}
