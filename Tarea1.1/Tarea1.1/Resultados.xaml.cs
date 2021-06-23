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
    public partial class Resultados : ContentPage
    {
        public Resultados(int num1, String sign, int num2, int resultados, String titulo)
        {
            InitializeComponent();


            N1.Text = num1.ToString();
            signo.Text = sign;
            N2.Text = num2.ToString();
            result.Text = resultados.ToString();
            titul.Text = titulo;
        }
    }
}