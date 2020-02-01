using System;
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

        private void LoginBtn_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(EntUserName.Text) || string.IsNullOrEmpty(EntPass.Text))
            {
                DisplayAlert("Mensaje","Campos Vacios","Ok");
            }
            else
            {
                DisplayAlert("Mensaje", "Bienvenido " + EntUserName.Text , "Ok");
            }
        }

        private void SignUp_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NewEmail.Text) || string.IsNullOrEmpty(NewUser.Text) || string.IsNullOrEmpty(NewPass.Text) || string.IsNullOrEmpty(ConfirmPass.Text))
            {
                DisplayAlert("Mensaje", "Campos Vacios", "Ok");                
            }
            else
            {
                if (ConfirmPass.Text != NewPass.Text)
                {
                    DisplayAlert("Mensaje", "La contraseña no coincide", "Ok");
                }
                else
                {
                    DisplayAlert("Bienvenido", "Registrado " + NewUser.Text, "Ok");
                    NewPass.Text = string.Empty;
                    NewEmail.Text = string.Empty;
                    NewUser.Text = string.Empty;
                    ConfirmPass.Text = string.Empty;
                }                
            }
        }
    }
}
