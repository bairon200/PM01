using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        double cm;
        double m;
        public Convertir()
        {
            InitializeComponent();
        }

        private void calcular()
        {
            cm = Convert.ToDouble(txtcm.Text);
            m = cm / 100;

            lblResultado.Text = m.ToString() + "m";
        }

        private void validar()
        {
            if (!string.IsNullOrEmpty(txtcm.Text))
            {
                calcular();
            }
            else
            {
                DisplayAlert("Error", "Ingrese un valor", "Ok");
            }
        }

        private void btnvolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btncalcular_Clicked(object sender, EventArgs e)
        {
            validar();
        }
    }
}