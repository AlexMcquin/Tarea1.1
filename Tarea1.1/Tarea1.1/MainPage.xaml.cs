using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1._1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void suma_Clicked(object sender, EventArgs e)
        {


            int Numero1 = Convert.ToInt32(this.txtN1.Text);

            String Signo = "+";

            int Numero2 = Convert.ToInt32(this.txtN2.Text);

            int Result = Convert.ToInt32(this.txtN1.Text) + Convert.ToInt32(this.txtN2.Text);

            String Titulo = "Suma Ejecutada";

            if (String.IsNullOrWhiteSpace(txtN1.Text))
            {
                DisplayAlert("Cuidado", "Llene los campos vacios", "Listo");

            }
            else if (String.IsNullOrWhiteSpace(txtN2.Text))
            {
                DisplayAlert("Cuidado", "Llene los campos vacios", "Listo");

            }

            else
            {

                await Navigation.PushAsync(new Resultados(Numero1, Signo, Numero2, Result, Titulo));
            }

        }

        private async void resta_Clicked(object sender, EventArgs e)
        {


            int Numero1 = Convert.ToInt32(this.txtN1.Text);

            String Signo = "-";

            int Numero2 = Convert.ToInt32(this.txtN2.Text);

            int Result = Convert.ToInt32(this.txtN1.Text) - Convert.ToInt32(this.txtN2.Text);

            String Titulo = "Resta Ejecutada";

            if (String.IsNullOrWhiteSpace(txtN1.Text))
            {
                DisplayAlert("Cuidado", "Llene los campos vacios", "Listo");

            }
            else if (String.IsNullOrWhiteSpace(txtN2.Text))
            {
                DisplayAlert("Cuidado", "Llene los campos vacios", "Listo");

            }

            else
            {

                await Navigation.PushAsync(new Resultados(Numero1, Signo, Numero2, Result, Titulo));
            }
        }

        private async void multiplicar_Clicked(object sender, EventArgs e)
        {

            int Numero1 = Convert.ToInt32(this.txtN1.Text);

            String Signo = "*";

            int Numero2 = Convert.ToInt32(this.txtN2.Text);

            int Result = Convert.ToInt32(this.txtN1.Text) * Convert.ToInt32(this.txtN2.Text);

            String Titulo = "Multiplicacion Ejecutada";

            if (String.IsNullOrWhiteSpace(txtN1.Text))
            {
                DisplayAlert("Cuidado", "Llene los campos vacios", "Listo");

            }
            else if (String.IsNullOrWhiteSpace(txtN2.Text))
            {
                DisplayAlert("Cuidado", "Llene los campos vacios", "Listo");

            }

            else
            {

                await Navigation.PushAsync(new Resultados(Numero1, Signo, Numero2, Result, Titulo));
            }
        }

        private async void division_Clicked(object sender, EventArgs e)
        {

            int Numero1 = Convert.ToInt32(this.txtN1.Text);

            String Signo = "/";

            int Numero2 = Convert.ToInt32(this.txtN2.Text);

            int Result = Convert.ToInt32(this.txtN1.Text) / Convert.ToInt32(this.txtN2.Text);

            String Titulo = "Division Ejecutada";

            if (string.IsNullOrWhiteSpace(txtN1.Text))
            {
                DisplayAlert("Cuidado", "Llene los campos vacios", "Listo");

            }
            else if (string.IsNullOrWhiteSpace(txtN2.Text))
            {
                DisplayAlert("Cuidado", "Llene los campos vacios", "Listo");

            }

            else
            {

                await Navigation.PushAsync(new Resultados(Numero1, Signo, Numero2, Result, Titulo));
            }
        }
    }
}
